namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class DeviceCreateBristolBsapIpCommand : AsyncCommand<DeviceCreateBristolBsapIpCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<DeviceCreateBristolBsapIpCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateBristolBsapIpCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<DeviceCreateBristolBsapIpCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateBristolBsapIpCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateBristolBsapIpCommandSettings settings,
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

            var request = BuildBristolBsapIpDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateBristolBsapIpDevice(
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

    private static BristolBsapIpDeviceRequest BuildBristolBsapIpDeviceRequest(
        DeviceCreateBristolBsapIpCommandSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,

            // Bristol BSAP IP Specific Settings
            Model = settings.Model is not null && settings.Model.IsSet
                ? settings.Model.Value
                : BristolBsapIpDeviceModelType.Dpc33Xx,
            RtuIpAddress = settings.RtuIpAddress,
            RtuGlobalAddress = settings.RtuGlobalAddress,
            RtuUdpPort = settings.RtuUdpPort,
            MaximumBytesPerRequest = settings.MaximumBytesPerRequest,
            Level = settings.Level is not null && settings.Level.IsSet
                ? settings.Level.Value
                : BristolBsapIpDeviceLevelType.Level1,
            RequestTimeoutMs = settings.RequestTimeoutMs,
            FailAfterSuccessiveTimeouts = settings.FailAfterSuccessiveTimeouts,
        };
}