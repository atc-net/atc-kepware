namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotItem;

public class IotItemDisableCommand : AsyncCommand<IotItemGetCommandSettings>
{
    private readonly ILogger<IotItemDisableCommand> logger;

    public IotItemDisableCommand(
        ILogger<IotItemDisableCommand> logger)
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

            var iotAgentResult = await kepwareConfigurationClient.GetIotAgentBase(
                settings.IotAgentName,
                CancellationToken.None);

            if (iotAgentResult.CommunicationSucceeded &&
                !iotAgentResult.HasData)
            {
                logger.LogWarning("Iot Agent does not exist!");
                return ConsoleExitStatusCodes.Success;
            }

            var iotItemResult = await kepwareConfigurationClient.GetIotAgentIotItem(
                settings.IotAgentName,
                CommandHelper.GetIotItemInternalNameFromServerTag(settings.ServerTag),
                CancellationToken.None);

            if (iotItemResult.CommunicationSucceeded &&
                !iotItemResult.HasData)
            {
                logger.LogWarning("Iot Agent Iot Item does not exist!");
                return ConsoleExitStatusCodes.Success;
            }

            if (!iotItemResult.Data!.Enabled)
            {
                logger.LogWarning("Iot Agent Iot Item already disabled!");
                return ConsoleExitStatusCodes.Success;
            }

            var result = await kepwareConfigurationClient.DisableIotAgentIotItem(
                settings.IotAgentName,
                iotAgentResult.Data!.ProjectId,
                CommandHelper.GetIotItemInternalNameFromServerTag(settings.ServerTag),
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