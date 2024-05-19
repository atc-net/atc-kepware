namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotItem;

public sealed class MqttClientIotItemUpdateCommand : AsyncCommand<IotItemUpdateCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<MqttClientIotItemUpdateCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public MqttClientIotItemUpdateCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<MqttClientIotItemUpdateCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotItemUpdateCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}