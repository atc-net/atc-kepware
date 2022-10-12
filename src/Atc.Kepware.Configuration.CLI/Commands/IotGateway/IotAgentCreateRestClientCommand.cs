namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway;

public class IotAgentCreateRestClientCommand : AsyncCommand<IotAgentCreateRestClientCommandSettings>
{
    private readonly ILogger<IotAgentCreateRestClientCommand> logger;

    public IotAgentCreateRestClientCommand(
        ILogger<IotAgentCreateRestClientCommand> logger)
        => this.logger = logger;

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
            var kepwareConfigurationClient = KepwareConfigurationClientBuilder.Build(settings, logger);

            var isIotAgentDefinedResult = await kepwareConfigurationClient.IsIotAgentDefined(
                settings.Name,
                CancellationToken.None);

            if (isIotAgentDefinedResult.CommunicationSucceeded &&
                isIotAgentDefinedResult.Data)
            {
                logger.LogWarning("Iot Agent already exists!");
                return ConsoleExitStatusCodes.Success;
            }

            var request = BuildIotAgentRestClientRequest(settings);
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

    private static IotAgentRestClientRequest BuildIotAgentRestClientRequest(
        IotAgentCreateRestClientCommandSettings settings)
    {
        var request = new IotAgentRestClientRequest
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

        if (settings.SendInitialUpdate is not null)
        {
            request.SendInitialUpdate = settings.SendInitialUpdate.Value;
        }

        if (settings.HttpHeaders.Count > 0)
        {
            request.HttpHeaders = TransformHttpHeaders(settings.HttpHeaders);
        }

        if (settings.PublishMediaType is not null &&
            settings.PublishMediaType.IsSet)
        {
            request.PublishMediaType = settings.PublishMediaType.Value;
        }

        return request;
    }

    private static string TransformHttpHeaders(
        IDictionary<string, string> httpHeaders)
    {
        var sb = new StringBuilder();

        foreach (var httpHeader in httpHeaders)
        {
            sb.Append($"{httpHeader.Key}: {httpHeader.Value}{Environment.NewLine}", GlobalizationConstants.EnglishCultureInfo);
        }

        return sb.ToString();
    }
}