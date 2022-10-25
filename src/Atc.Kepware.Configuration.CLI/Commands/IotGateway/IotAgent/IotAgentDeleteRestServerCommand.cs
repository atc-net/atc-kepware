namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotAgent;

public class IotAgentDeleteRestServerCommand : AsyncCommand<IotAgentCommandBaseSettings>
{
    private readonly ILogger<IotAgentDeleteRestServerCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public IotAgentDeleteRestServerCommand(
        ILogger<IotAgentDeleteRestServerCommand> logger,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.logger = logger;
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