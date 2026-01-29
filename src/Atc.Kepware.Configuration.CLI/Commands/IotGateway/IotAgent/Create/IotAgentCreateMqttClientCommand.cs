// ReSharper disable InvertIf
namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotAgent.Create;

public sealed class IotAgentCreateMqttClientCommand : AsyncCommand<IotAgentCreateMqttClientCommandSettings>
{
    private readonly ILogger<IotAgentCreateMqttClientCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public IotAgentCreateMqttClientCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<IotAgentCreateMqttClientCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotAgentCreateMqttClientCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        IotAgentCreateMqttClientCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            kepwareConfigurationClient.SetConnectionInformation(
                new Uri(settings.ServerUrl),
                settings.UserName!.Value,
                settings.Password!.Value);

            var isIotAgentDefinedResult = await kepwareConfigurationClient.IsIotAgentDefined(
                settings.Name,
                cancellationToken);

            if (!isIotAgentDefinedResult.CommunicationSucceeded)
            {
                return ConsoleExitStatusCodes.Failure;
            }

            if (isIotAgentDefinedResult.Data)
            {
                logger.LogWarning("Iot Agent already exists!");
                return ConsoleExitStatusCodes.Success;
            }

            var request = BuildIotAgentMqttClientCreateRequest(settings);
            var result = await kepwareConfigurationClient.CreateIotAgentMqttClient(request, cancellationToken);

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

    private static IotAgentMqttClientCreateRequest BuildIotAgentMqttClientCreateRequest(
        IotAgentCreateMqttClientCommandSettings settings)
    {
        var request = new IotAgentMqttClientCreateRequest
        {
            Name = settings.Name,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,
            Url = settings.Url,
            Topic = settings.Topic,
            ClientId = settings.ClientId,
            Qos = settings.Qos,
            Rate = settings.Rate,
            PublishFormat = settings.PublishFormat,
            MaxEventsPerPublish = settings.MaxEventsPerPublish,
            TransactionTimeout = settings.TransactionTimeout,
            PublishMessageFormat = settings.PublishMessageFormat,
        };

        if (settings.IgnoreQualityChanges.HasValue)
        {
            request.IgnoreQualityChanges = settings.IgnoreQualityChanges.Value;
        }

        if (settings.SendInitialUpdate is not null)
        {
            request.SendInitialUpdate = settings.SendInitialUpdate.Value;
        }

        if (settings.MqttUserName is not null && settings.MqttUserName.IsSet &&
            settings.MqttPassword is not null && settings.MqttPassword.IsSet)
        {
            request.UserName = settings.MqttUserName.Value;
            request.Password = settings.MqttPassword.Value;
        }

        return request;
    }
}