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

            var isTagDefined = await kepwareConfigurationClient.IsTagDefined(
                settings.ChannelName,
                settings.DeviceName,
                settings.TagGroups,
                settings.TagName,
                CancellationToken.None);

            if (isTagDefined)
            {
                logger.LogWarning("Tag already exists!");
                return ConsoleExitStatusCodes.Success;
            }

            var request = new TagRequest
            {
                Name = settings.TagName,
                Description = "MyTag2 Description",
                Address = "R5",
                DataType = TagDataType.Word,
                ClientAccess = TagClientAccessType.ReadOnly,
                ScanRate = 100,
            };

            var result = await kepwareConfigurationClient.CreateTag(
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
}