namespace Atc.Kepware.Configuration.CLI.Commands;

public class TagsDeleteTagCommand : AsyncCommand<TagDeleteCommandSettings>
{
    private readonly ILogger<TagsDeleteTagCommand> logger;

    public TagsDeleteTagCommand(
        ILogger<TagsDeleteTagCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        TagDeleteCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        TagDeleteCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            var kepwareConfigurationClient = KepwareConfigurationClientBuilder.Build(settings, logger);

            var isTagDefined = await kepwareConfigurationClient.IsTagDefined(
                settings.ChannelName,
                settings.DeviceName,
                settings.Name,
                settings.TagGroups,
                CancellationToken.None);

            if (!isTagDefined)
            {
                logger.LogWarning("Tag does not exist!");
                return ConsoleExitStatusCodes.Success;
            }

            var result = await kepwareConfigurationClient.DeleteTag(
                settings.ChannelName,
                settings.DeviceName,
                settings.Name,
                settings.TagGroups,
                CancellationToken.None);

            if (!result.CommunicationSucceeded && !result.Data)
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