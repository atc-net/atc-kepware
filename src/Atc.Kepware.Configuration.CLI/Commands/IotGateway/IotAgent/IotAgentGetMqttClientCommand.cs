namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotAgent;

public class IotAgentGetMqttClientCommand : AsyncCommand<IotAgentCommandBaseSettings>
{
    private readonly ILogger<IotAgentGetMqttClientCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public IotAgentGetMqttClientCommand(
        ILogger<IotAgentGetMqttClientCommand> logger,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.logger = logger;
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotAgentCommandBaseSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}