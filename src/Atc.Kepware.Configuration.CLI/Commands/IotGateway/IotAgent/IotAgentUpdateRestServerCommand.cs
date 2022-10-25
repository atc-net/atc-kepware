namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotAgent;

public class IotAgentUpdateRestServerCommand : AsyncCommand<IotAgentUpdateRestServerCommandSettings>
{
    private readonly ILogger<IotAgentUpdateRestServerCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public IotAgentUpdateRestServerCommand(
        ILogger<IotAgentUpdateRestServerCommand> logger,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.logger = logger;
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotAgentUpdateRestServerCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}