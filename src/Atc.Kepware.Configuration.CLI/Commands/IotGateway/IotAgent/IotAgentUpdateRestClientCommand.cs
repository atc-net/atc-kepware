// ReSharper disable InvertIf
namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotAgent;

public class IotAgentUpdateRestClientCommand : AsyncCommand<IotAgentUpdateRestClientCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<IotAgentUpdateRestClientCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public IotAgentUpdateRestClientCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<IotAgentUpdateRestClientCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotAgentUpdateRestClientCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        IotAgentUpdateRestClientCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            kepwareConfigurationClient.SetConnectionInformation(
                new Uri(settings.ServerUrl),
                settings.UserName!.Value,
                settings.Password!.Value);

            var iotAgentResult = await kepwareConfigurationClient.GetIotAgentRestClient(
                settings.Name,
                CancellationToken.None);

            if (!iotAgentResult.CommunicationSucceeded)
            {
                return ConsoleExitStatusCodes.Failure;
            }

            if (!iotAgentResult.HasData)
            {
                logger.LogWarning("Iot Agent does not exist!");
                return ConsoleExitStatusCodes.Success;
            }

            var (shouldUpdate, request) = BuildIotAgentRestClientUpdateRequest(
                settings,
                iotAgentResult.Data!);

            if (!shouldUpdate)
            {
                logger.LogWarning("Nothing to update on Iot Agent!");
                return ConsoleExitStatusCodes.Success;
            }

            var result = await kepwareConfigurationClient.UpdateIotAgentRestClient(
                settings.Name,
                request,
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

    [SuppressMessage("Design", "MA0051:Method is too long", Justification = "OK.")]
    private static (bool ShouldUpdate, IotAgentRestClientUpdateRequest Request) BuildIotAgentRestClientUpdateRequest(
        IotAgentUpdateRestClientCommandSettings settings,
        IotAgentRestClient existingIotRestClient)
    {
        var shouldUpdate = false;
        var request = new IotAgentRestClientUpdateRequest
        {
            ProjectId = existingIotRestClient.ProjectId,
        };

        if (settings.Description is not null &&
            settings.Description.IsSet &&
            !settings.Description.Value.Equals(existingIotRestClient.Description, StringComparison.Ordinal))
        {
            request.Description = settings.Description.Value;
            shouldUpdate = true;
        }

        if (settings.IgnoreQualityChanges is not null &&
            settings.IgnoreQualityChanges.IsSet &&
            settings.IgnoreQualityChanges.Value != existingIotRestClient.IgnoreQualityChanges)
        {
            request.IgnoreQualityChanges = settings.IgnoreQualityChanges.Value;
            shouldUpdate = true;
        }

        if (settings.Enabled is not null &&
            settings.Enabled.IsSet &&
            settings.Enabled.Value != existingIotRestClient.Enabled)
        {
            request.Enabled = settings.Enabled.Value;
            shouldUpdate = true;
        }

        if (settings.Url is not null &&
            settings.Url.IsSet &&
            settings.Url.Value.Equals(existingIotRestClient.Url, StringComparison.Ordinal))
        {
            request.Url = settings.Url.Value;
            shouldUpdate = true;
        }

        if (settings.PublishHttpMethod is not null &&
            settings.PublishHttpMethod.IsSet &&
            settings.PublishHttpMethod.Value != existingIotRestClient.PublishHttpMethod)
        {
            request.PublishHttpMethod = settings.PublishHttpMethod.Value;
            shouldUpdate = true;
        }

        if (settings.Rate is not null &&
            settings.Rate.IsSet &&
            settings.Rate.Value != existingIotRestClient.Rate)
        {
            request.Rate = settings.Rate.Value;
            shouldUpdate = true;
        }

        if (settings.PublishFormat is not null &&
            settings.PublishFormat.IsSet &&
            settings.PublishFormat.Value != existingIotRestClient.PublishFormat)
        {
            request.PublishFormat = settings.PublishFormat.Value;
            shouldUpdate = true;
        }

        if (settings.MaxEventsPerPublish is not null &&
            settings.MaxEventsPerPublish.IsSet &&
            settings.MaxEventsPerPublish.Value != existingIotRestClient.MaxEventsPerPublish)
        {
            request.MaxEventsPerPublish = settings.MaxEventsPerPublish.Value;
            shouldUpdate = true;
        }

        if (settings.TransactionTimeout is not null &&
            settings.TransactionTimeout.IsSet &&
            settings.TransactionTimeout.Value != existingIotRestClient.TransactionTimeout)
        {
            request.TransactionTimeout = settings.TransactionTimeout.Value;
            shouldUpdate = true;
        }

        if (settings.SendInitialUpdate is not null &&
            settings.SendInitialUpdate.IsSet &&
            settings.SendInitialUpdate.Value != existingIotRestClient.SendInitialUpdate)
        {
            request.SendInitialUpdate = settings.SendInitialUpdate.Value;
            shouldUpdate = true;
        }

        if (settings.HttpHeaders is not null &&
            settings.HttpHeaders.IsSet &&
            settings.HttpHeaders.Value.Count > 0)
        {
            request.HttpHeaders = CommandHelper.TransformHttpHeaders(settings.HttpHeaders.Value);
            shouldUpdate = true;
        }

        if (settings.PublishMessageFormat is not null &&
            settings.PublishMessageFormat.IsSet &&
            settings.PublishMessageFormat.Value != existingIotRestClient.PublishMessageFormat)
        {
            request.PublishMessageFormat = settings.PublishMessageFormat.Value;
            shouldUpdate = true;
        }

        if (settings.PublishMediaType is not null &&
            settings.PublishMediaType.IsSet &&
            settings.PublishMediaType.Value != existingIotRestClient.PublishMediaType)
        {
            request.PublishMediaType = settings.PublishMediaType.Value;
            shouldUpdate = true;
        }

        if (settings.UrlUserName is not null && settings.UrlUserName.IsSet &&
            settings.UrlPassword is not null && settings.UrlPassword.IsSet)
        {
            request.UserName = settings.UrlUserName.Value;
            request.Password = settings.UrlPassword.Value;
            shouldUpdate = true;
        }

        return (shouldUpdate, request);
    }
}