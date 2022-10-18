namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway;

public class IotAgentRestServerIotItemCreateCommand : AsyncCommand<IotItemCreateCommandSettings>
{
    private readonly ILogger<IotAgentRestServerIotItemCreateCommand> logger;

    public IotAgentRestServerIotItemCreateCommand(
        ILogger<IotAgentRestServerIotItemCreateCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotItemCreateCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}