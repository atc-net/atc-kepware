namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway;

public class IotAgentGetMqttClientCommand : AsyncCommand<IotAgentGetSingleCommandSettings>
{
    private readonly ILogger<IotAgentGetMqttClientCommand> logger;

    public IotAgentGetMqttClientCommand(
        ILogger<IotAgentGetMqttClientCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotAgentGetSingleCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}