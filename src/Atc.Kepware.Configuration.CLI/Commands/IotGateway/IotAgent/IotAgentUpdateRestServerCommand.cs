// ReSharper disable InvertIf
namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotAgent;

public sealed class IotAgentUpdateRestServerCommand : AsyncCommand<IotAgentUpdateRestServerCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<IotAgentUpdateRestServerCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public IotAgentUpdateRestServerCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<IotAgentUpdateRestServerCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotAgentUpdateRestServerCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        IotAgentUpdateRestServerCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            kepwareConfigurationClient.SetConnectionInformation(
                new Uri(settings.ServerUrl),
                settings.UserName!.Value,
                settings.Password!.Value);

            var iotAgentResult = await kepwareConfigurationClient.GetIotAgentRestServer(
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

            var (shouldUpdate, request) = BuildIotAgentRestServerUpdateRequest(
                settings,
                iotAgentResult.Data!);

            if (!shouldUpdate)
            {
                logger.LogWarning("Nothing to update on Iot Agent!");
                return ConsoleExitStatusCodes.Success;
            }

            var result = await kepwareConfigurationClient.UpdateIotAgentRestServer(
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
    private static (bool ShouldUpdate, IotAgentRestServerUpdateRequest Request) BuildIotAgentRestServerUpdateRequest(
        IotAgentUpdateRestServerCommandSettings settings,
        IotAgentRestServer existingIotRestServer)
    {
        var shouldUpdate = false;
        var request = new IotAgentRestServerUpdateRequest
        {
            ProjectId = existingIotRestServer.ProjectId,
        };

        if (settings.Description is not null &&
            settings.Description.IsSet &&
            !settings.Description.Value.Equals(existingIotRestServer.Description, StringComparison.Ordinal))
        {
            request.Description = settings.Description.Value;
            shouldUpdate = true;
        }

        if (settings.IgnoreQualityChanges is not null &&
            settings.IgnoreQualityChanges.IsSet &&
            settings.IgnoreQualityChanges.Value != existingIotRestServer.IgnoreQualityChanges)
        {
            request.IgnoreQualityChanges = settings.IgnoreQualityChanges.Value;
            shouldUpdate = true;
        }

        if (settings.Enabled is not null &&
            settings.Enabled.IsSet &&
            settings.Enabled.Value != existingIotRestServer.Enabled)
        {
            request.Enabled = settings.Enabled.Value;
            shouldUpdate = true;
        }

        if (settings.Port is not null &&
            settings.Port.IsSet &&
            settings.Port.Value != existingIotRestServer.Port)
        {
            request.Port = settings.Port.Value;
            shouldUpdate = true;
        }

        if (settings.AllowAnonymous is not null &&
            settings.AllowAnonymous.IsSet &&
            settings.AllowAnonymous.Value != existingIotRestServer.AllowAnonymous)
        {
            request.AllowAnonymous = settings.AllowAnonymous.Value;
            shouldUpdate = true;
        }

        if (settings.AllowWrite is not null &&
            settings.AllowWrite.IsSet &&
            settings.AllowWrite.Value != existingIotRestServer.AllowWrite)
        {
            request.AllowWrite = settings.AllowWrite.Value;
            shouldUpdate = true;
        }

        if (settings.CorsAllowedOrigins is not null &&
            settings.CorsAllowedOrigins.IsSet &&
            !settings.CorsAllowedOrigins.Value.Equals(existingIotRestServer.CorsAllowedOrigins, StringComparison.Ordinal))
        {
            request.CorsAllowedOrigins = settings.CorsAllowedOrigins.Value;
            shouldUpdate = true;
        }

        return (shouldUpdate, request);
    }
}