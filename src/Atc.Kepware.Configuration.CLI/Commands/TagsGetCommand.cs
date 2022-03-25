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
                OutputTagRoot(result.Data);
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

    private void OutputTagRoot(
        TagRoot tagRoot)
    {
        logger.LogInformation($"Device:   {tagRoot.DeviceName}");

        foreach (var tag in tagRoot.Tags)
        {
            logger.LogInformation($"Tag:        {tag.Name}");
        }

        foreach (var tagGroup in tagRoot.TagGroups)
        {
            logger.LogInformation($"TagGroup:   {tagGroup.Name}");

            foreach (var tag in tagGroup.Tags)
            {
                logger.LogInformation($"Tag:          {tag.Name}");
            }

            OutputTagGroup(tagGroup, 1);
        }
    }

    private void OutputTagGroup(
        TagGroup tagGroup,
        int level)
    {
        foreach (var group in tagGroup.TagGroups)
        {
            var spaces = string.Empty.PadRight(level * 2);
            logger.LogInformation($"TagGroup:{spaces}   {group.Name}");

            foreach (var tag in group.Tags)
            {
                logger.LogInformation($"Tag:{spaces}          {tag.Name}");
            }

            OutputTagGroup(group, level + 1);
        }
    }
}