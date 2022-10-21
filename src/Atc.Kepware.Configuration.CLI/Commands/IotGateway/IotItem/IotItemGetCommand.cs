namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotItem;

public class IotItemGetCommand : AsyncCommand<IotItemGetCommandSettings>
{
    private readonly ILogger<IotItemGetCommand> logger;

    public IotItemGetCommand(
        ILogger<IotItemGetCommand> logger)
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

            var result = await kepwareConfigurationClient.GetIotAgentIotItem(
                settings.IotAgentName,
                CommandHelper.GetIotItemInternalNameFromServerTag(settings.ServerTag),
                CancellationToken.None);

            if (result.CommunicationSucceeded &&
                result.HasData)
            {
                var item = result.Data!;
                var properties = item.GetType().GetPublicProperties();
                foreach (var property in properties)
                {
                    var typeName = $"{property.BeautifyName()}";
                    var spaces = string.Empty.PadRight(10 - typeName.Length);
                    logger.LogInformation($"{typeName}{spaces}{property.Name}: {item.GetPropertyValue(property.Name)}");
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(result.Message))
                {
                    logger.LogWarning(result.Message);
                }

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