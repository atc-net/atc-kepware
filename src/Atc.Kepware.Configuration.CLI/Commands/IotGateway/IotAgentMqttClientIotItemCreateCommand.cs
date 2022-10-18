namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway;

public class IotAgentMqttClientIotItemCreateCommand : AsyncCommand<IotItemCreateCommandSettings>
{
    private readonly ILogger<IotAgentMqttClientIotItemCreateCommand> logger;

    public IotAgentMqttClientIotItemCreateCommand(
        ILogger<IotAgentMqttClientIotItemCreateCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotItemCreateCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}