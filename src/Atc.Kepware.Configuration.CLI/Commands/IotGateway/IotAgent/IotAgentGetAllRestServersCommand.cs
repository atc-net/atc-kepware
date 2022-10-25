namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotAgent;

public class IotAgentGetAllRestServersCommand : AsyncCommand<KepwareBaseCommandSettings>
{
    private readonly ILogger<IotAgentGetAllRestServersCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public IotAgentGetAllRestServersCommand(
        ILogger<IotAgentGetAllRestServersCommand> logger,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.logger = logger;
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        KepwareBaseCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}