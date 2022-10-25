namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public class TagsGetCommand : AsyncCommand<TagsGetCommandSettings>
{
    private readonly ILogger<TagsGetCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public TagsGetCommand(
        ILogger<TagsGetCommand> logger,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.logger = logger;
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

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
            kepwareConfigurationClient.SetConnectionInformation(
                new Uri(settings.ServerUrl),
                settings.UserName!.Value,
                settings.Password!.Value);

            var result = await kepwareConfigurationClient.GetTags(
                settings.ChannelName,
                settings.DeviceName,
                settings.MaxDepth < 1 ? 1 : settings.MaxDepth,
                CancellationToken.None);

            if (result.CommunicationSucceeded &&
                result.HasData)
            {
                OutputTagRoot(result.Data!);
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