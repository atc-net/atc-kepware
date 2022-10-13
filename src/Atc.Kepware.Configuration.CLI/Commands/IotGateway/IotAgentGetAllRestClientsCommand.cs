namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway;

public class IotAgentGetAllRestClientsCommand : AsyncCommand<KepwareBaseCommandSettings>
{
    private readonly ILogger<IotAgentGetAllRestClientsCommand> logger;

    public IotAgentGetAllRestClientsCommand(
        ILogger<IotAgentGetAllRestClientsCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        KepwareBaseCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        KepwareBaseCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            var kepwareConfigurationClient = KepwareConfigurationClientBuilder.Build(settings, logger);

            var result = await kepwareConfigurationClient.GetIotAgentRestClients(CancellationToken.None);

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
}