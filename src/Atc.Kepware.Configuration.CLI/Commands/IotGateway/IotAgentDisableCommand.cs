namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway;

public class IotAgentDisableCommand : AsyncCommand<IotAgentCommandBaseSettings>
{
    private readonly ILogger<IotAgentDisableCommand> logger;

    public IotAgentDisableCommand(
        ILogger<IotAgentDisableCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotAgentCommandBaseSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        IotAgentCommandBaseSettings settings)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            var kepwareConfigurationClient = KepwareConfigurationClientBuilder.Build(settings, logger);

            var iotAgentResult = await kepwareConfigurationClient.GetIotAgentBase(
                settings.Name,
                CancellationToken.None);

            if (iotAgentResult.CommunicationSucceeded &&
                !iotAgentResult.HasData)
            {
                logger.LogWarning("Iot Agent does not exist!");
                return ConsoleExitStatusCodes.Success;
            }

            if (!iotAgentResult.Data!.Enabled)
            {
                logger.LogWarning("Iot Agent already disabled!");
                return ConsoleExitStatusCodes.Success;
            }

            var result = await kepwareConfigurationClient.DisableIotAgent(
                settings.Name,
                iotAgentResult.Data!.ProjectId,
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
}