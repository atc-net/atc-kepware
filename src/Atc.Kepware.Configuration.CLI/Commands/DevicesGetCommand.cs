namespace Atc.Kepware.Configuration.CLI.Commands;

public class DevicesGetCommand : AsyncCommand<DevicesGetCommandSettings>
{
    private readonly ILogger<DevicesGetCommand> logger;

    public DevicesGetCommand(
        ILogger<DevicesGetCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DevicesGetCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        DevicesGetCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            var userName = settings.UserName;
            var password = settings.Password;

            using var kepwareConfigurationClient = userName is not null && userName.IsSet
                ? new KepwareConfigurationClient(
                    logger,
                    new Uri(settings.ServerUrl),
                    userName.Value,
                    password!.Value)
                : new KepwareConfigurationClient(
                    logger,
                    new Uri(settings.ServerUrl),
                    userName: null,
                    password: null);

            var result = await kepwareConfigurationClient.GetDevices(settings.ChannelName, CancellationToken.None);
            if (result.CommunicationSucceeded && result.HasData)
            {
                foreach (var deviceBase in result.Data!)
                {
                    logger.LogInformation($"{deviceBase.Name} - {deviceBase.Driver}");
                }
            }
            else
            {
                return ConsoleExitStatusCodes.Failure;
            }
        }
        catch (Exception ex)
        {
            logger.LogError($"{EmojisConstants.Error} {ex.GetMessage()}");
            return ConsoleExitStatusCodes.Failure;
        }

        logger.LogInformation($"{EmojisConstants.Success} Done");
        return ConsoleExitStatusCodes.Success;
    }
}