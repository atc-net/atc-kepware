namespace Atc.Kepware.Configuration.CLI.Commands;

public class ChannelCreateOpcUaClientCommand : AsyncCommand<ChannelCreateOpcUaClientCommandSettings>
{
    private readonly ILogger<ChannelCreateOpcUaClientCommand> logger;

    public ChannelCreateOpcUaClientCommand(
        ILogger<ChannelCreateOpcUaClientCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        ChannelCreateOpcUaClientCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        ChannelCreateOpcUaClientCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            var userName = settings.UserName;
            var password = settings.Password;

            using var kepwareConfigurationClient = userName is not null && userName.IsSet
                ? new KepwareConfigurationClient(
                    logger,
                    new Uri(settings.ServerUrl),
                    userName.Value,
                    password!.Value)
                : new KepwareConfigurationClient(
                    logger,
                    new Uri(settings.ServerUrl),
                    userName: null,
                    password: null);

            // TODO: Check if exists...

            var request = BuildOpcUaClientChannelRequest(settings);
            var result = await kepwareConfigurationClient.CreateOpcUaClientChannel(request, CancellationToken.None);
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

    private static OpcUaClientChannelRequest BuildOpcUaClientChannelRequest(
        ChannelCreateOpcUaClientCommandSettings settings)
        => new()
        {
            Name = settings.Name,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,
            CaptureDiagnostics = settings.CaptureDiagnostics,
            OptimizationMethod = settings.OptimizationMethod is not null && settings.OptimizationMethod.IsSet
                ? settings.OptimizationMethod.Value
                : ChannelOptimizationMethodType.WriteOnlyLatestValueForAllTags,
            WriteOptimizationDutyCycle = settings.WriteOptimizationDutyCycle,
            NonNormalizedFloatingPointHandling = settings.NonNormalizedFloatingPointHandling is not null && settings.NonNormalizedFloatingPointHandling.IsSet
                ? settings.NonNormalizedFloatingPointHandling.Value
                : ChannelNonNormalizedFloatingPointHandlingType.ReplaceWithZero,

            // OPC UA Specific Settings
            EndpointUrl = settings.EndpointUrl,
            ServerSecurityPolicy = settings.ServerSecurityPolicy is not null && settings.ServerSecurityPolicy.IsSet
                ? settings.ServerSecurityPolicy.Value
                : OpcUaServerSecurityPolicyType.None,
            UserName = settings.OpcUaUserName is not null && settings.OpcUaUserName.IsSet
                ? settings.OpcUaUserName.Value
                : string.Empty,
            Password = settings.OpcUaPassword is not null && settings.OpcUaPassword.IsSet
                ? settings.OpcUaPassword.Value
                : string.Empty,
            ServerMessageMode = settings.ServerMessageMode is not null && settings.ServerMessageMode.IsSet
                ? settings.ServerMessageMode.Value
                : OpcUaServerMessageModeType.None,
            ConnectTimeoutSeconds = settings.ConnectTimeoutSeconds,
            SessionTimeoutInactiveMinutes = settings.SessionTimeoutInactiveMinutes,
            SessionRenewalIntervalMinutes = settings.SessionRenewalIntervalMinutes,
            SessionFailedConnectionRetryIntervalSeconds = settings.SessionFailedConnectionRetryIntervalSeconds,
            SessionWatchdogTimeout = settings.SessionWatchdogTimeout,
        };
}