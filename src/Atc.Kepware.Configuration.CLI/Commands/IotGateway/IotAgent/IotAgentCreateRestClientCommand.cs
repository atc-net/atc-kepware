namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotAgent;

public class IotAgentCreateRestClientCommand : AsyncCommand<IotAgentCreateRestClientCommandSettings>
{
    private readonly ILogger<IotAgentCreateRestClientCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public IotAgentCreateRestClientCommand(
        ILogger<IotAgentCreateRestClientCommand> logger,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.logger = logger;
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotAgentCreateRestClientCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        IotAgentCreateRestClientCommandSettings settings)
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
                CancellationToken.None);

            if (!isIotAgentDefinedResult.CommunicationSucceeded)
            {
                return ConsoleExitStatusCodes.Failure;
            }

            if (isIotAgentDefinedResult.Data)
            {
                logger.LogWarning("Iot Agent already exists!");
                return ConsoleExitStatusCodes.Success;
            }

            var request = BuildIotAgentRestClientCreateRequest(settings);
            var result = await kepwareConfigurationClient.CreateIotAgentRestClient(request, CancellationToken.None);

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

    private static IotAgentRestClientCreateRequest BuildIotAgentRestClientCreateRequest(
        IotAgentCreateRestClientCommandSettings settings)
    {
        var request = new IotAgentRestClientCreateRequest
        {
            Name = settings.Name,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,
            Url = settings.Url,
            PublishHttpMethod = settings.PublishHttpMethod,
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

        if (settings.HttpHeaders.Count > 0)
        {
            request.HttpHeaders = CommandHelper.TransformHttpHeaders(settings.HttpHeaders);
        }

        if (settings.PublishMediaType is not null &&
            settings.PublishMediaType.IsSet)
        {
            request.PublishMediaType = settings.PublishMediaType.Value;
        }

        return request;
    }
}