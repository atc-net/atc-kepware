namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public class TagsDeleteTagCommand : AsyncCommand<TagDeleteCommandSettings>
{
    private readonly ILogger<TagsDeleteTagCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public TagsDeleteTagCommand(
        ILogger<TagsDeleteTagCommand> logger,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.logger = logger;
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

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
            kepwareConfigurationClient.SetConnectionInformation(
                new Uri(settings.ServerUrl),
                settings.UserName!.Value,
                settings.Password!.Value);

            var isTagDefinedResult = await kepwareConfigurationClient.IsTagDefined(
                settings.ChannelName,
                settings.DeviceName,
                settings.Name,
                settings.TagGroups,
                CancellationToken.None);

            if (!isTagDefinedResult.CommunicationSucceeded)
            {
                return ConsoleExitStatusCodes.Failure;
            }

            if (!isTagDefinedResult.Data)
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