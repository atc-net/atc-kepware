namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway;

public class IotAgentGetRestServerCommand : AsyncCommand<IotAgentGetSingleCommandSettings>
{
    private readonly ILogger<IotAgentGetRestServerCommand> logger;

    public IotAgentGetRestServerCommand(
        ILogger<IotAgentGetRestServerCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotAgentGetSingleCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}