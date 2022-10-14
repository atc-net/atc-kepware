namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway;

public class IotAgentDeleteMqttClientCommand : AsyncCommand<IotAgentCommandBaseSettings>
{
    private readonly ILogger<IotAgentDeleteMqttClientCommand> logger;

    public IotAgentDeleteMqttClientCommand(
        ILogger<IotAgentDeleteMqttClientCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotAgentCommandBaseSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}