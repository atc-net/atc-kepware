namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class DeviceCreateOpcDaClientCommand : AsyncCommand<DeviceCreateOpcDaClientCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<DeviceCreateOpcDaClientCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateOpcDaClientCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<DeviceCreateOpcDaClientCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateOpcDaClientCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateOpcDaClientCommandSettings settings,
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

            var request = BuildOpcDaClientDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateOpcDaClientDevice(
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

    private static OpcDaClientDeviceRequest BuildOpcDaClientDeviceRequest(
        DeviceCreateOpcDaClientCommandSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,

            // OPC DA Client Specific Settings
            GroupName = settings.GroupName is not null && settings.GroupName.IsSet
                ? settings.GroupName.Value
                : null,
            UpdateMode = settings.UpdateMode is not null && settings.UpdateMode.IsSet
                ? settings.UpdateMode.Value
                : OpcDaClientUpdateMode.Exception,
            UpdatePollRate = settings.UpdatePollRate,
            PercentDeadband = settings.PercentDeadband,
            LanguageId = settings.LanguageId,
            WriteMethod = settings.WriteMethod is not null && settings.WriteMethod.IsSet
                ? settings.WriteMethod.Value
                : OpcDaClientReadWriteMethod.Asynchronous,
            ReadMethod = settings.ReadMethod is not null && settings.ReadMethod.IsSet
                ? settings.ReadMethod.Value
                : OpcDaClientReadWriteMethod.Asynchronous,
            MaxItemsPerRead = settings.MaxItemsPerRead,
            MaxItemsPerWrite = settings.MaxItemsPerWrite,
            WriteTimeout = settings.WriteTimeout,
            ReadAfterWrite = settings.ReadAfterWrite,
            Watchdog = settings.Watchdog,
            WatchdogItemId = settings.WatchdogItemId is not null && settings.WatchdogItemId.IsSet
                ? settings.WatchdogItemId.Value
                : null,
            MissedUpdatesBeforeReconnect = settings.MissedUpdatesBeforeReconnect,
        };
}