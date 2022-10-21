namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotAgent;

public class IotAgentGetAllRestServersCommand : AsyncCommand<KepwareBaseCommandSettings>
{
    private readonly ILogger<IotAgentGetAllRestServersCommand> logger;

    public IotAgentGetAllRestServersCommand(
        ILogger<IotAgentGetAllRestServersCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        KepwareBaseCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}