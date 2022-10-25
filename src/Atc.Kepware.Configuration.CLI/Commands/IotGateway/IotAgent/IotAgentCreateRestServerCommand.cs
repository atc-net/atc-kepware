namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotAgent;

public class IotAgentCreateRestServerCommand : AsyncCommand<IotAgentCreateRestServerCommandSettings>
{
    private readonly ILogger<IotAgentCreateRestServerCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public IotAgentCreateRestServerCommand(
        ILogger<IotAgentCreateRestServerCommand> logger,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.logger = logger;
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotAgentCreateRestServerCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}