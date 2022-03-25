namespace Atc.Kepware.Configuration.CLI.Commands;

public class ChannelsGetCommand : AsyncCommand<ChannelsGetCommandSettings>
{
    private readonly ILogger<ChannelsGetCommand> logger;

    public ChannelsGetCommand(
        ILogger<ChannelsGetCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        ChannelsGetCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        ChannelsGetCommandSettings settings)
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

            var result = await kepwareConfigurationClient.GetChannels(CancellationToken.None);
            if (result.CommunicationSucceeded && result.HasData)
            {
                foreach (var channelBase in result.Data!)
                {
                    logger.LogInformation($"{channelBase.Name} - {channelBase.DeviceDriver}");
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