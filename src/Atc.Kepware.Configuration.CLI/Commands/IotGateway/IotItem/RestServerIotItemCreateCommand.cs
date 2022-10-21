namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotItem;

public class RestServerIotItemCreateCommand : AsyncCommand<IotItemCreateCommandSettings>
{
    private readonly ILogger<RestServerIotItemCreateCommand> logger;

    public RestServerIotItemCreateCommand(
        ILogger<RestServerIotItemCreateCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotItemCreateCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}