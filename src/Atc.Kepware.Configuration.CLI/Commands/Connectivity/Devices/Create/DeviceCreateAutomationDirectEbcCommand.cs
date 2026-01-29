namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity.Devices.Create;

public sealed class DeviceCreateAutomationDirectEbcCommand : AsyncCommand<DeviceCreateAutomationDirectEbcCommandSettings>
{
    private readonly ILogger<DeviceCreateAutomationDirectEbcCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateAutomationDirectEbcCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<DeviceCreateAutomationDirectEbcCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateAutomationDirectEbcCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateAutomationDirectEbcCommandSettings settings,
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

            var request = BuildAutomationDirectEbcDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateAutomationDirectEbcDevice(
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

    private static AutomationDirectEbcDeviceRequest BuildAutomationDirectEbcDeviceRequest(
        DeviceCreateAutomationDirectEbcCommandSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,

            // AutomationDirect EBC Specific Settings
            DeviceId = settings.DeviceId,
            Model = settings.Model,
            Port = settings.Port,
            UseLinkWatchdog = settings.UseLinkWatchdog,
            WatchdogTimeoutMs = settings.WatchdogTimeoutMs,
            AutoTagGenerationPort = settings.AutoTagGenerationPort,
        };
}