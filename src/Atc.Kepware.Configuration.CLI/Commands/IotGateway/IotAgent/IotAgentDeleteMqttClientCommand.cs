namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotAgent;

public sealed class IotAgentDeleteMqttClientCommand : AsyncCommand<IotAgentCommandBaseSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<IotAgentDeleteMqttClientCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public IotAgentDeleteMqttClientCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<IotAgentDeleteMqttClientCommand>();
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