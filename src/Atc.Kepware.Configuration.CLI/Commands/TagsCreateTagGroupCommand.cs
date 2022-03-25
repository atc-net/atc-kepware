namespace Atc.Kepware.Configuration.CLI.Commands;

public class TagsCreateTagGroupCommand : AsyncCommand<TagGroupCreateCommandSettings>
{
    private readonly ILogger<TagsCreateTagGroupCommand> logger;

    public TagsCreateTagGroupCommand(
        ILogger<TagsCreateTagGroupCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        TagGroupCreateCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        TagGroupCreateCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            var kepwareConfigurationClient = KepwareConfigurationClientBuilder.BuildKepwareConfigurationClient(settings, logger);

            var isTagGroupDefined = await kepwareConfigurationClient.IsTagGroupDefined(
                settings.ChannelName,
                settings.DeviceName,
                settings.Name,
                settings.TagGroups,
                CancellationToken.None);

            if (isTagGroupDefined)
            {
                logger.LogWarning("Tag Group already exists!");
                return ConsoleExitStatusCodes.Success;
            }

            var request = BuildTagGroupRequest(settings);
            var result = await kepwareConfigurationClient.CreateTagGroup(
                request,
                settings.ChannelName,
                settings.DeviceName,
                settings.TagGroups,
                CancellationToken.None);

            if (!result.CommunicationSucceeded ||
                result.StatusCode is not (HttpStatusCode.OK or HttpStatusCode.Created))
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

    private static TagGroupRequest BuildTagGroupRequest(
        TagGroupCreateCommandSettings settings)
        => new TagGroupRequest
        {
            Name = settings.Name,
            Description = settings.Description,
        };
}