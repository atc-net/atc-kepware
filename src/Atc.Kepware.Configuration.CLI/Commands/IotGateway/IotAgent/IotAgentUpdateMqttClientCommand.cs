// ReSharper disable InvertIf
namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotAgent;

public sealed class IotAgentUpdateMqttClientCommand : AsyncCommand<IotAgentUpdateMqttClientCommandSettings>
{
    private readonly ILogger<IotAgentUpdateMqttClientCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public IotAgentUpdateMqttClientCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<IotAgentUpdateMqttClientCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotAgentUpdateMqttClientCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        IotAgentUpdateMqttClientCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            kepwareConfigurationClient.SetConnectionInformation(
                new Uri(settings.ServerUrl),
                settings.UserName!.Value,
                settings.Password!.Value);

            var iotAgentResult = await kepwareConfigurationClient.GetIotAgentMqttClient(
                settings.Name,
                cancellationToken);

            if (!iotAgentResult.CommunicationSucceeded)
            {
                return ConsoleExitStatusCodes.Failure;
            }

            if (!iotAgentResult.HasData)
            {
                logger.LogWarning("Iot Agent does not exist!");
                return ConsoleExitStatusCodes.Success;
            }

            var (shouldUpdate, request) = BuildIotAgentMqttClientUpdateRequest(
                settings,
                iotAgentResult.Data!);

            if (!shouldUpdate)
            {
                logger.LogWarning("Nothing to update on Iot Agent!");
                return ConsoleExitStatusCodes.Success;
            }

            var result = await kepwareConfigurationClient.UpdateIotAgentMqttClient(
                settings.Name,
                request,
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

    [SuppressMessage("Design", "MA0051:Method is too long", Justification = "OK.")]
    private static (bool ShouldUpdate, IotAgentMqttClientUpdateRequest Request) BuildIotAgentMqttClientUpdateRequest(
        IotAgentUpdateMqttClientCommandSettings settings,
        IotAgentMqttClient existingIotMqttClient)
    {
        var shouldUpdate = false;
        var request = new IotAgentMqttClientUpdateRequest
        {
            ProjectId = existingIotMqttClient.ProjectId,
        };

        if (settings.Description is not null &&
            settings.Description.IsSet &&
            !settings.Description.Value.Equals(existingIotMqttClient.Description, StringComparison.Ordinal))
        {
            request.Description = settings.Description.Value;
            shouldUpdate = true;
        }

        if (settings.IgnoreQualityChanges is not null &&
            settings.IgnoreQualityChanges.IsSet &&
            settings.IgnoreQualityChanges.Value != existingIotMqttClient.IgnoreQualityChanges)
        {
            request.IgnoreQualityChanges = settings.IgnoreQualityChanges.Value;
            shouldUpdate = true;
        }

        if (settings.Enabled is not null &&
            settings.Enabled.IsSet &&
            settings.Enabled.Value != existingIotMqttClient.Enabled)
        {
            request.Enabled = settings.Enabled.Value;
            shouldUpdate = true;
        }

        if (settings.Url is not null &&
            settings.Url.IsSet &&
            !settings.Url.Value.Equals(existingIotMqttClient.Url, StringComparison.Ordinal))
        {
            request.Url = settings.Url.Value;
            shouldUpdate = true;
        }

        if (settings.Topic is not null &&
            settings.Topic.IsSet &&
            !settings.Topic.Value.Equals(existingIotMqttClient.Topic, StringComparison.Ordinal))
        {
            request.Topic = settings.Topic.Value;
            shouldUpdate = true;
        }

        if (settings.ClientId is not null &&
            settings.ClientId.IsSet &&
            !settings.ClientId.Value.Equals(existingIotMqttClient.ClientId, StringComparison.Ordinal))
        {
            request.ClientId = settings.ClientId.Value;
            shouldUpdate = true;
        }

        if (settings.Qos is not null &&
            settings.Qos.IsSet &&
            settings.Qos.Value != existingIotMqttClient.Qos)
        {
            request.Qos = settings.Qos.Value;
            shouldUpdate = true;
        }

        if (settings.Rate is not null &&
            settings.Rate.IsSet &&
            settings.Rate.Value != existingIotMqttClient.Rate)
        {
            request.Rate = settings.Rate.Value;
            shouldUpdate = true;
        }

        if (settings.PublishFormat is not null &&
            settings.PublishFormat.IsSet &&
            settings.PublishFormat.Value != existingIotMqttClient.PublishFormat)
        {
            request.PublishFormat = settings.PublishFormat.Value;
            shouldUpdate = true;
        }

        if (settings.MaxEventsPerPublish is not null &&
            settings.MaxEventsPerPublish.IsSet &&
            settings.MaxEventsPerPublish.Value != existingIotMqttClient.MaxEventsPerPublish)
        {
            request.MaxEventsPerPublish = settings.MaxEventsPerPublish.Value;
            shouldUpdate = true;
        }

        if (settings.TransactionTimeout is not null &&
            settings.TransactionTimeout.IsSet &&
            settings.TransactionTimeout.Value != existingIotMqttClient.TransactionTimeout)
        {
            request.TransactionTimeout = settings.TransactionTimeout.Value;
            shouldUpdate = true;
        }

        if (settings.SendInitialUpdate is not null &&
            settings.SendInitialUpdate.IsSet &&
            settings.SendInitialUpdate.Value != existingIotMqttClient.SendInitialUpdate)
        {
            request.SendInitialUpdate = settings.SendInitialUpdate.Value;
            shouldUpdate = true;
        }

        if (settings.PublishMessageFormat is not null &&
            settings.PublishMessageFormat.IsSet &&
            settings.PublishMessageFormat.Value != existingIotMqttClient.PublishMessageFormat)
        {
            request.PublishMessageFormat = settings.PublishMessageFormat.Value;
            shouldUpdate = true;
        }

        if (settings.MqttUserName is not null && settings.MqttUserName.IsSet &&
            settings.MqttPassword is not null && settings.MqttPassword.IsSet)
        {
            request.UserName = settings.MqttUserName.Value;
            request.Password = settings.MqttPassword.Value;
            shouldUpdate = true;
        }

        return (shouldUpdate, request);
    }
}