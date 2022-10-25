namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotItem;

public class RestServerIotItemUpdateCommand : AsyncCommand<IotItemUpdateCommandSettings>
{
    private readonly ILogger<RestServerIotItemUpdateCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public RestServerIotItemUpdateCommand(
        ILogger<RestServerIotItemUpdateCommand> logger,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.logger = logger;
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