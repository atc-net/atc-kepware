namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway;

public class IotAgentCreateRestServerCommand : AsyncCommand<IotAgentCreateRestServerCommandSettings>
{
    private readonly ILogger<IotAgentCreateRestServerCommand> logger;

    public IotAgentCreateRestServerCommand(
        ILogger<IotAgentCreateRestServerCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotAgentCreateRestServerCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}