namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public class ChannelsGetCommand : AsyncCommand<KepwareBaseCommandSettings>
{
    private readonly ILogger<ChannelsGetCommand> logger;

    public ChannelsGetCommand(
        ILogger<ChannelsGetCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        KepwareBaseCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        KepwareBaseCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            var kepwareConfigurationClient = KepwareConfigurationClientBuilder.Build(settings, logger);

            var result = await kepwareConfigurationClient.GetChannels(CancellationToken.None);
            if (result.CommunicationSucceeded &&
                result.HasData)
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