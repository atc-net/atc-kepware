namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class DeviceCreateAutomationDirectEcomCommand : AsyncCommand<DeviceCreateAutomationDirectEcomCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<DeviceCreateAutomationDirectEcomCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateAutomationDirectEcomCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<DeviceCreateAutomationDirectEcomCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateAutomationDirectEcomCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateAutomationDirectEcomCommandSettings settings)
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

            var request = BuildAutomationDirectEcomDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateAutomationDirectEcomDevice(
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

    private static AutomationDirectEcomDeviceRequest BuildAutomationDirectEcomDeviceRequest(
        DeviceCreateAutomationDirectEcomCommandSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,

            // AutomationDirect ECOM Specific Settings
            DeviceId = settings.DeviceId,
            Model = settings.Model is not null && settings.Model.IsSet
                ? settings.Model.Value
                : AutomationDirectEcomDeviceModelType.Dl05,
            IdFormat = settings.IdFormat is not null && settings.IdFormat.IsSet
                ? settings.IdFormat.Value
                : AutomationDirectEcomDeviceIdFormatType.Octal,
            Port = settings.Port,
            ConnectTimeoutSeconds = settings.ConnectTimeoutSeconds,
            RequestTimeoutMs = settings.RequestTimeoutMs,
            RetryAttempts = settings.RetryAttempts,
        };
}
