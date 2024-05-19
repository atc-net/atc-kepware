namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotAgent;

public sealed class IotAgentDeleteRestServerCommand : AsyncCommand<IotAgentCommandBaseSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<IotAgentDeleteRestServerCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public IotAgentDeleteRestServerCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<IotAgentDeleteRestServerCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotAgentCommandBaseSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}