namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway;

public class IotAgentUpdateMqttClientCommand : AsyncCommand<IotAgentUpdateMqttClientCommandSettings>
{
    private readonly ILogger<IotAgentUpdateMqttClientCommand> logger;

    public IotAgentUpdateMqttClientCommand(
        ILogger<IotAgentUpdateMqttClientCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotAgentUpdateMqttClientCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}