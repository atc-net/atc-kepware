// ReSharper disable InvertIf
namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotAgent;

public sealed class IotAgentCreateRestServerCommand : AsyncCommand<IotAgentCreateRestServerCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<IotAgentCreateRestServerCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public IotAgentCreateRestServerCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<IotAgentCreateRestServerCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotAgentCreateRestServerCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        IotAgentCreateRestServerCommandSettings settings,
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

            var request = BuildIotAgentRestServerCreateRequest(settings);
            var result = await kepwareConfigurationClient.CreateIotAgentRestServer(request, cancellationToken);

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

    private static IotAgentRestServerCreateRequest BuildIotAgentRestServerCreateRequest(
        IotAgentCreateRestServerCommandSettings settings)
    {
        var request = new IotAgentRestServerCreateRequest
        {
            Name = settings.Name,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,
            Port = settings.Port,
        };

        if (settings.IgnoreQualityChanges.HasValue)
        {
            request.IgnoreQualityChanges = settings.IgnoreQualityChanges.Value;
        }

        if (settings.AllowAnonymous.HasValue)
        {
            request.AllowAnonymous = settings.AllowAnonymous.Value;
        }

        if (settings.AllowWrite.HasValue)
        {
            request.AllowWrite = settings.AllowWrite.Value;
        }

        if (settings.CorsAllowedOrigins is not null && settings.CorsAllowedOrigins.IsSet)
        {
            request.CorsAllowedOrigins = settings.CorsAllowedOrigins.Value;
        }

        return request;
    }
}