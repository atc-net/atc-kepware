namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class DeviceCreateHoneywellUdcEthernetCommand : AsyncCommand<DeviceCreateHoneywellUdcEthernetCommandSettings>
{
    private readonly ILogger<DeviceCreateHoneywellUdcEthernetCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateHoneywellUdcEthernetCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<DeviceCreateHoneywellUdcEthernetCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateHoneywellUdcEthernetCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateHoneywellUdcEthernetCommandSettings settings,
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

            var request = BuildHoneywellUdcEthernetDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateHoneywellUdcEthernetDevice(
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

    private static HoneywellUdcEthernetDeviceRequest BuildHoneywellUdcEthernetDeviceRequest(
        DeviceCreateHoneywellUdcEthernetCommandSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,

            // Honeywell UDC Ethernet Specific Settings
            DeviceId = settings.DeviceId,
            Model = settings.Model is not null && settings.Model.IsSet
                ? settings.Model.Value
                : HoneywellUdcEthernetDeviceModelType.UDC2500,
            Port = settings.Port,
            ConnectTimeoutSeconds = settings.ConnectTimeoutSeconds,
            RequestTimeoutMs = settings.RequestTimeoutMs,
            RetryAttempts = settings.RetryAttempts,
            FirstWordLow = settings.FirstWordLow,
            InternalRegisters = settings.InternalRegisters,
            HoldingRegisters = settings.HoldingRegisters,
        };
}