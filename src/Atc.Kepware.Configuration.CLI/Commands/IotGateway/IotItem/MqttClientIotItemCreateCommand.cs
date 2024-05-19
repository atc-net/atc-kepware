namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotItem;

public class MqttClientIotItemCreateCommand : AsyncCommand<IotItemCreateCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<MqttClientIotItemCreateCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public MqttClientIotItemCreateCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<MqttClientIotItemCreateCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotItemCreateCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}