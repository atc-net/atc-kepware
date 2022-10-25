namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotAgent;

public class IotAgentCreateMqttClientCommand : AsyncCommand<IotAgentCreateMqttClientCommandSettings>
{
    private readonly ILogger<IotAgentCreateMqttClientCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public IotAgentCreateMqttClientCommand(
        ILogger<IotAgentCreateMqttClientCommand> logger,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.logger = logger;
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotAgentCreateMqttClientCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}