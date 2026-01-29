namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class DeviceCreateScanivalveEthernetCommand : AsyncCommand<DeviceCreateScanivalveEthernetCommandSettings>
{
    private readonly ILogger<DeviceCreateScanivalveEthernetCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateScanivalveEthernetCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<DeviceCreateScanivalveEthernetCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateScanivalveEthernetCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateScanivalveEthernetCommandSettings settings,
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

            var request = BuildScanivalveEthernetDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateScanivalveEthernetDevice(
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

    private static ScanivalveEthernetDeviceRequest BuildScanivalveEthernetDeviceRequest(
        DeviceCreateScanivalveEthernetCommandSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,

            // Scanivalve Ethernet Specific Settings
            Model = settings.Model is not null && settings.Model.IsSet
                ? settings.Model.Value
                : ScanivalveEthernetDeviceModelType.Dsa3200,
            DeviceId = settings.DeviceId,
            Port = settings.Port,
            ConnectTimeoutSeconds = settings.ConnectTimeoutSeconds,
            RequestTimeoutMs = settings.RequestTimeoutMs,
            RetryAttempts = settings.RetryAttempts,
        };
}