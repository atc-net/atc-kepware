namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class DeviceCreateEuroMap63Command : AsyncCommand<DeviceCreateEuroMap63CommandBaseSettings>
{
    private readonly ILogger<DeviceCreateEuroMap63Command> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateEuroMap63Command(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<DeviceCreateEuroMap63Command>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateEuroMap63CommandBaseSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateEuroMap63CommandBaseSettings settings,
        CancellationToken cancellationToken)
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
                cancellationToken);

            if (!isDeviceDefinedResult.CommunicationSucceeded)
            {
                return ConsoleExitStatusCodes.Failure;
            }

            if (isDeviceDefinedResult.Data)
            {
                logger.LogWarning("Device already exists!");
                return ConsoleExitStatusCodes.Success;
            }

            var request = BuildEuroMap63DeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateEuroMap63Device(
                request,
                settings.ChannelName,
                cancellationToken);

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

    private static EuroMap63DeviceRequest BuildEuroMap63DeviceRequest(
        DeviceCreateEuroMap63CommandBaseSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,
            SessionFilePath = settings.SessionFilePath,
        };
}