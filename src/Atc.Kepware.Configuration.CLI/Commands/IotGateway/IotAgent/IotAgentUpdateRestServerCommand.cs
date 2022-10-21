namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotAgent;

public class IotAgentUpdateRestServerCommand : AsyncCommand<IotAgentUpdateRestServerCommandSettings>
{
    private readonly ILogger<IotAgentUpdateRestServerCommand> logger;

    public IotAgentUpdateRestServerCommand(
        ILogger<IotAgentUpdateRestServerCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotAgentUpdateRestServerCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}