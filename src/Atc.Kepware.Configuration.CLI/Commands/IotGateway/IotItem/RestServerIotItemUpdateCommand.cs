namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotItem;

public class RestServerIotItemUpdateCommand : AsyncCommand<IotItemUpdateCommandSettings>
{
    private readonly ILogger<RestServerIotItemUpdateCommand> logger;

    public RestServerIotItemUpdateCommand(
        ILogger<RestServerIotItemUpdateCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotItemUpdateCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}