namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotAgent;

public sealed class IotAgentDisableCommand : AsyncCommand<IotAgentCommandBaseSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<IotAgentDisableCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public IotAgentDisableCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<IotAgentDisableCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

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
            kepwareConfigurationClient.SetConnectionInformation(
                new Uri(settings.ServerUrl),
                settings.UserName!.Value,
                settings.Password!.Value);

            var iotAgentResult = await kepwareConfigurationClient.GetIotAgentBase(
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

            if (!iotAgentResult.Data!.Enabled)
            {
                logger.LogWarning("Iot Agent already disabled!");
                return ConsoleExitStatusCodes.Success;
            }

            var result = await kepwareConfigurationClient.DisableIotAgent(
                settings.Name,
                iotAgentResult.Data!.ProjectId,
                CancellationToken.None);

            if (result is { CommunicationSucceeded: false, Data: false })
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