namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class DeviceCreateAllenBradleyControlLogixEthernetCommand : AsyncCommand<DeviceCreateAllenBradleyControlLogixEthernetCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<DeviceCreateAllenBradleyControlLogixEthernetCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateAllenBradleyControlLogixEthernetCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<DeviceCreateAllenBradleyControlLogixEthernetCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateAllenBradleyControlLogixEthernetCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateAllenBradleyControlLogixEthernetCommandSettings settings)
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

            var request = BuildAllenBradleyControlLogixEthernetDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateAllenBradleyControlLogixEthernetDevice(
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

    private static AllenBradleyControlLogixEthernetDeviceRequest BuildAllenBradleyControlLogixEthernetDeviceRequest(
        DeviceCreateAllenBradleyControlLogixEthernetCommandSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,

            // Allen-Bradley ControlLogix Ethernet Specific Settings
            DeviceId = settings.DeviceId,
            Model = settings.Model is not null && settings.Model.IsSet
                ? settings.Model.Value
                : ControlLogixDeviceModelType.ControlLogix5500,
            Port = settings.Port,
            ConnectionSizeBytes = settings.ConnectionSizeBytes,
            InactivityWatchdog = settings.InactivityWatchdog is not null && settings.InactivityWatchdog.IsSet
                ? settings.InactivityWatchdog.Value
                : ControlLogixInactivityWatchdogType.Seconds32,
            ArrayBlockSize = settings.ArrayBlockSize is not null && settings.ArrayBlockSize.IsSet
                ? settings.ArrayBlockSize.Value
                : ControlLogixArrayBlockSizeType.Elements120,
            ProtocolMode = settings.ProtocolMode is not null && settings.ProtocolMode.IsSet
                ? settings.ProtocolMode.Value
                : ControlLogixProtocolModeType.LogicalNonBlocking,
            SynchronizeAfterOnlineEdits = settings.SynchronizeAfterOnlineEdits,
            SynchronizeAfterOfflineEdits = settings.SynchronizeAfterOfflineEdits,
        };
}