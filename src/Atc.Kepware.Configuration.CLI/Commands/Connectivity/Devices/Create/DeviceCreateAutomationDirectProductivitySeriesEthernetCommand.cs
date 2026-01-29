namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity.Devices.Create;

public sealed class DeviceCreateAutomationDirectProductivitySeriesEthernetCommand : AsyncCommand<DeviceCreateAutomationDirectProductivitySeriesEthernetCommandSettings>
{
    private readonly ILogger<DeviceCreateAutomationDirectProductivitySeriesEthernetCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateAutomationDirectProductivitySeriesEthernetCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<DeviceCreateAutomationDirectProductivitySeriesEthernetCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateAutomationDirectProductivitySeriesEthernetCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateAutomationDirectProductivitySeriesEthernetCommandSettings settings,
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

            var request = BuildAutomationDirectProductivitySeriesEthernetDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateAutomationDirectProductivitySeriesEthernetDevice(
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

    private static AutomationDirectProductivitySeriesEthernetDeviceRequest BuildAutomationDirectProductivitySeriesEthernetDeviceRequest(
        DeviceCreateAutomationDirectProductivitySeriesEthernetCommandSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,

            // AutomationDirect Productivity Series Ethernet Specific Settings
            DeviceId = settings.DeviceId,
            Port = settings.Port,
            FirstWordHigh = settings.FirstWordHigh,
            TagImportFile = settings.TagImportFile is not null && settings.TagImportFile.IsSet
                ? settings.TagImportFile.Value
                : null,
        };
}