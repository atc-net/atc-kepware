namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class ChannelCreateMqttClientCommand : AsyncCommand<ChannelCreateMqttClientCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<ChannelCreateMqttClientCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public ChannelCreateMqttClientCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<ChannelCreateMqttClientCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        ChannelCreateMqttClientCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        ChannelCreateMqttClientCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            kepwareConfigurationClient.SetConnectionInformation(
                new Uri(settings.ServerUrl),
                settings.UserName!.Value,
                settings.Password!.Value);

            var isChannelDefinedResult = await kepwareConfigurationClient.IsChannelDefined(
                settings.Name,
                CancellationToken.None);

            if (!isChannelDefinedResult.CommunicationSucceeded)
            {
                return ConsoleExitStatusCodes.Failure;
            }

            if (isChannelDefinedResult.Data)
            {
                logger.LogWarning("Channel already exists!");
                return ConsoleExitStatusCodes.Success;
            }

            var request = BuildMqttClientChannelRequest(settings);
            var result = await kepwareConfigurationClient.CreateMqttClientChannel(request, CancellationToken.None);
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

    private static MqttClientChannelRequest BuildMqttClientChannelRequest(
        ChannelCreateMqttClientCommandSettings settings)
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

            // MQTT Client Specific Settings
            Host = settings.Host is not null && settings.Host.IsSet
                ? settings.Host.Value
                : "localhost",
            Port = settings.Port,
            SslTls = settings.SslTls,
            ClientId = settings.ClientId is not null && settings.ClientId.IsSet
                ? settings.ClientId.Value
                : null,
            Username = settings.MqttUsername is not null && settings.MqttUsername.IsSet
                ? settings.MqttUsername.Value
                : null,
            Password = settings.MqttPassword is not null && settings.MqttPassword.IsSet
                ? settings.MqttPassword.Value
                : null,
            ClientCertificate = settings.ClientCertificate,
            MqttServerVersion = settings.MqttServerVersion is not null && settings.MqttServerVersion.IsSet
                ? settings.MqttServerVersion.Value
                : MqttClientServerVersionType.Auto,
            SubscriptionQos = settings.SubscriptionQos is not null && settings.SubscriptionQos.IsSet
                ? settings.SubscriptionQos.Value
                : MqttClientSubscriptionQosType.AtMostOnce,
            ConnectTimeout = settings.ConnectTimeout,
            ReconnectMinimum = settings.ReconnectMinimum,
            ReconnectMaximum = settings.ReconnectMaximum,
            KeepAlive = settings.KeepAlive,
        };
}