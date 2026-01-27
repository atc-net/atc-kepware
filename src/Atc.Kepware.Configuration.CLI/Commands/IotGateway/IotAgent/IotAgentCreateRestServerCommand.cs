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
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}