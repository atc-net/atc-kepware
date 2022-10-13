namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway;

public class IotAgentGetAllMqttClientsCommand : AsyncCommand<KepwareBaseCommandSettings>
{
    private readonly ILogger<IotAgentGetAllMqttClientsCommand> logger;

    public IotAgentGetAllMqttClientsCommand(
        ILogger<IotAgentGetAllMqttClientsCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        KepwareBaseCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}