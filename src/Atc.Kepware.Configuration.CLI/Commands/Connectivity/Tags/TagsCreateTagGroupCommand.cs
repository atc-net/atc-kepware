namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity.Tags;

public sealed class TagsCreateTagGroupCommand : AsyncCommand<TagGroupCreateCommandSettings>
{
    private readonly ILogger<TagsCreateTagGroupCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public TagsCreateTagGroupCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<TagsCreateTagGroupCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        TagGroupCreateCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        TagGroupCreateCommandSettings settings,
        CancellationToken cancellationToken)
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
                cancellationToken);

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
                cancellationToken);

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