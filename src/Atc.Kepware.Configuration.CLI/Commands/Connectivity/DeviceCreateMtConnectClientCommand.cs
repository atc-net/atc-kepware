namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class DeviceCreateMtConnectClientCommand : AsyncCommand<DeviceCreateMtConnectClientCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<DeviceCreateMtConnectClientCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateMtConnectClientCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<DeviceCreateMtConnectClientCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateMtConnectClientCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateMtConnectClientCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            kepwareConfigurationClient.SetConnectionInformation(
                new Uri(settings.ServerUrl),
                settings.UserName!.Value,
                settings.Password!.Value);

            var isDeviceDefinedResult = await kepwareConfigurationClient.IsDeviceDefined(
                settings.ChannelName,
                settings.DeviceName,
                CancellationToken.None);

            if (!isDeviceDefinedResult.CommunicationSucceeded)
            {
                return ConsoleExitStatusCodes.Failure;
            }

            if (isDeviceDefinedResult.Data)
            {
                logger.LogWarning("Device already exists!");
                return ConsoleExitStatusCodes.Success;
            }

            var request = BuildMtConnectClientDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateMtConnectClientDevice(
                request,
                settings.ChannelName,
                CancellationToken.None);

            if (!result.CommunicationSucceeded ||
                result.StatusCode is not (HttpStatusCode.OK or HttpStatusCode.Created))
            {
                return ConsoleExitStatusCodes.Failure;
            }
        }
        catch (Exception ex)
        {
            logger.LogError($"{EmojisConstants.Error} {ex.GetMessage()}");
            return ConsoleExitStatusCodes.Failure;
        }

        logger.LogInformation($"{EmojisConstants.Success} Done");
        return ConsoleExitStatusCodes.Success;
    }

    private static MtConnectClientDeviceRequest BuildMtConnectClientDeviceRequest(
        DeviceCreateMtConnectClientCommandSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,
            DeviceId = settings.MtConnectDeviceId is not null && settings.MtConnectDeviceId.IsSet
                ? settings.MtConnectDeviceId.Value
                : string.Empty,
        };
}
