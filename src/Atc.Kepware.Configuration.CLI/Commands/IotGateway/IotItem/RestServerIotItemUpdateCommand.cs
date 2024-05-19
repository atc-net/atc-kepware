namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotItem;

public class RestServerIotItemUpdateCommand : AsyncCommand<IotItemUpdateCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<RestServerIotItemUpdateCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public RestServerIotItemUpdateCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<RestServerIotItemUpdateCommand>();
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