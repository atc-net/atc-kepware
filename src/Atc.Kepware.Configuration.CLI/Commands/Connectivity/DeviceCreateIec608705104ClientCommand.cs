namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class DeviceCreateIec608705104ClientCommand : AsyncCommand<DeviceCreateIec608705104ClientCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<DeviceCreateIec608705104ClientCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateIec608705104ClientCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<DeviceCreateIec608705104ClientCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateIec608705104ClientCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateIec608705104ClientCommandSettings settings,
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

            var request = BuildIec608705104ClientDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateIec608705104ClientDevice(
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

    private static Iec608705104ClientDeviceRequest BuildIec608705104ClientDeviceRequest(
        DeviceCreateIec608705104ClientCommandSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,

            // IEC 60870-5-104 Client Specific Settings
            CommonAddress = settings.CommonAddress,
            PolledReads = settings.PolledReads,
            RequestTimeout = settings.RequestTimeout,
            InterrogationRequestTimeout = settings.InterrogationRequestTimeout,
            AttemptCount = settings.AttemptCount,
            InterrogationAttemptCount = settings.InterrogationAttemptCount,
            TimeSyncInitialization = settings.TimeSyncInitialization is not null && settings.TimeSyncInitialization.IsSet
                ? settings.TimeSyncInitialization.Value
                : Iec608705104InitializationType.EndOfInitialization,
            GiInitialization = settings.GiInitialization is not null && settings.GiInitialization.IsSet
                ? settings.GiInitialization.Value
                : Iec608705104InitializationType.EndOfInitialization,
            CiInitialization = settings.CiInitialization is not null && settings.CiInitialization.IsSet
                ? settings.CiInitialization.Value
                : Iec608705104InitializationType.EndOfInitialization,
            PeriodicGiInterval = settings.PeriodicGiInterval,
            PeriodicCiInterval = settings.PeriodicCiInterval,
            TestProcedure = settings.TestProcedure,
            TestProcedurePeriod = settings.TestProcedurePeriod,
            PlaybackEvents = settings.PlaybackEvents,
            PlaybackBufferSize = settings.PlaybackBufferSize,
            PlaybackRate = settings.PlaybackRate,
        };
}