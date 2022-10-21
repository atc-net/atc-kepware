namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotItem;

public class MqttClientIotItemUpdateCommand : AsyncCommand<IotItemUpdateCommandSettings>
{
    private readonly ILogger<MqttClientIotItemUpdateCommand> logger;

    public MqttClientIotItemUpdateCommand(
        ILogger<MqttClientIotItemUpdateCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotItemUpdateCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}