namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotAgent;

public class IotAgentCreateMqttClientCommand : AsyncCommand<IotAgentCreateMqttClientCommandSettings>
{
    private readonly ILogger<IotAgentCreateMqttClientCommand> logger;

    public IotAgentCreateMqttClientCommand(
        ILogger<IotAgentCreateMqttClientCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotAgentCreateMqttClientCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}