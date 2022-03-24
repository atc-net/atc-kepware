namespace Atc.Kepware.Configuration.CLI.Commands;

public class TagsGetCommand : AsyncCommand<TagsGetCommandSettings>
{
    private readonly ILogger<TagsGetCommand> logger;

    public TagsGetCommand(
        ILogger<TagsGetCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        TagsGetCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        TagsGetCommandSettings settings)
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

            var result = await kepwareConfigurationClient.GetTags(
                settings.ChannelName,
                settings.DeviceName,
                settings.MaxDepth < 1 ? 1 : settings.MaxDepth,
                CancellationToken.None);

            if (result.HasCommunicationSucceeded && result.Data is not null)
            {
                foreach (var tag in result.Data.Tags)
                {
                    logger.LogInformation($"Tag: {tag.Name}");
                }

                foreach (var tagGroup in result.Data.TagGroups)
                {
                    logger.LogInformation($"TagGroup: {tagGroup.Name}");
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