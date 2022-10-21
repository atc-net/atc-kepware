namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotItem;

public class MqttClientIotItemCreateCommand : AsyncCommand<IotItemCreateCommandSettings>
{
    private readonly ILogger<MqttClientIotItemCreateCommand> logger;

    public MqttClientIotItemCreateCommand(
        ILogger<MqttClientIotItemCreateCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotItemCreateCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}