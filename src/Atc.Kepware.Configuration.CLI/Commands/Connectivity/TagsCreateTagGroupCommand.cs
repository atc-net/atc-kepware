namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public class TagsCreateTagGroupCommand : AsyncCommand<TagGroupCreateCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<TagsCreateTagGroupCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public TagsCreateTagGroupCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<TagsCreateTagGroupCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

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
            kepwareConfigurationClient.SetConnectionInformation(
                new Uri(settings.ServerUrl),
                settings.UserName!.Value,
                settings.Password!.Value);

            var isTagGroupDefinedResult = await kepwareConfigurationClient.IsTagGroupDefined(
                settings.ChannelName,
                settings.DeviceName,
                settings.Name,
                settings.TagGroups,
                CancellationToken.None);

            if (!isTagGroupDefinedResult.CommunicationSucceeded)
            {
                return ConsoleExitStatusCodes.Failure;
            }

            if (isTagGroupDefinedResult.Data)
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

    private static TagGroupRequest BuildTagGroupRequest(
        TagGroupCreateCommandSettings settings)
        => new()
        {
            Name = settings.Name,
            Description = settings.Description,
        };
}