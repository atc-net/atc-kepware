namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway;

public class IotAgentIotItemDeleteCommand : AsyncCommand<IotItemGetCommandSettings>
{
    private readonly ILogger<IotAgentIotItemDeleteCommand> logger;

    public IotAgentIotItemDeleteCommand(
        ILogger<IotAgentIotItemDeleteCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotItemGetCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        IotItemGetCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            var kepwareConfigurationClient = KepwareConfigurationClientBuilder.Build(settings, logger);

            var isIotAgentDefinedResult = await kepwareConfigurationClient.IsIotAgentDefined(
                settings.IotAgentName,
                CancellationToken.None);

            if (isIotAgentDefinedResult.CommunicationSucceeded &&
                !isIotAgentDefinedResult.Data)
            {
                logger.LogWarning("Iot Agent does not exist!");
                return ConsoleExitStatusCodes.Success;
            }

            var result = await kepwareConfigurationClient.DeleteIotAgentIotItem(
                settings.IotAgentName,
                GetIotItemInternalNameFromServerTag(settings.ServerTag),
                CancellationToken.None);

            if (!result.CommunicationSucceeded &&
                !result.Data)
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

    private static string GetIotItemInternalNameFromServerTag(
        string serverTag)
        => serverTag.TrimExtended().Replace('.', '_');
}