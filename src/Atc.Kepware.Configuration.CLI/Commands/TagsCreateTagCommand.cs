namespace Atc.Kepware.Configuration.CLI.Commands;

public class TagsCreateTagCommand : AsyncCommand<TagCreateCommandSettings>
{
    private readonly ILogger<TagsCreateTagCommand> logger;

    public TagsCreateTagCommand(
        ILogger<TagsCreateTagCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        TagCreateCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        TagCreateCommandSettings settings)
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

            if (isTagDefined)
            {
                logger.LogWarning("Tag already exists!");
                return ConsoleExitStatusCodes.Success;
            }

            var request = BuildTagRequest(settings);
            var result = await kepwareConfigurationClient.CreateTag(
                request,
                settings.ChannelName,
                settings.DeviceName,
                settings.TagGroups,
                ensureTagGroupStructure: true,
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

    private static TagRequest BuildTagRequest(
        TagCreateCommandSettings settings)
        => new()
        {
            Name = settings.Name,
            Description = settings.Description,
            Address = settings.Address,
            DataType = settings.DataType is not null && settings.DataType.IsSet
                ? settings.DataType.Value
                : TagDataType.Word,
            ClientAccess = settings.ClientAccess is not null && settings.ClientAccess.IsSet
                ? settings.ClientAccess.Value
                : TagClientAccessType.ReadOnly,
            ScanRate = settings.ScanRate,
        };
}