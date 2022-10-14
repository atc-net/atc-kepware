namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway;

public class IotAgentGetRestServerCommand : AsyncCommand<IotAgentCommandBaseSettings>
{
    private readonly ILogger<IotAgentGetRestServerCommand> logger;

    public IotAgentGetRestServerCommand(
        ILogger<IotAgentGetRestServerCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotAgentCommandBaseSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}