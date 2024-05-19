namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotAgent;

public sealed class IotAgentUpdateMqttClientCommand : AsyncCommand<IotAgentUpdateMqttClientCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<IotAgentUpdateMqttClientCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public IotAgentUpdateMqttClientCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<IotAgentUpdateMqttClientCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotAgentUpdateMqttClientCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}