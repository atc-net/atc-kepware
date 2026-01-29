namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class TagsDeleteTagGroupCommand : AsyncCommand<TagGroupDeleteCommandSettings>
{
    private readonly ILogger<TagsDeleteTagGroupCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public TagsDeleteTagGroupCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<TagsDeleteTagGroupCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        TagGroupDeleteCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        TagGroupDeleteCommandSettings settings,
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

            if (!isTagGroupDefinedResult.Data)
            {
                logger.LogWarning("Tag Group does not exist!");
                return ConsoleExitStatusCodes.Success;
            }

            var result = await kepwareConfigurationClient.DeleteTagGroup(
                settings.ChannelName,
                settings.DeviceName,
                settings.Name,
                settings.TagGroups,
                cancellationToken);

            if (result is { CommunicationSucceeded: false, Data: false })
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