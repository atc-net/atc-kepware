namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public class TagsSearchCommand : AsyncCommand<TagsSearchCommandSettings>
{
    private readonly ILogger<TagsSearchCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public TagsSearchCommand(
        ILogger<TagsSearchCommand> logger,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.logger = logger;
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        TagsSearchCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        TagsSearchCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            kepwareConfigurationClient.SetConnectionInformation(
                new Uri(settings.ServerUrl),
                settings.UserName!.Value,
                settings.Password!.Value);

            var result = await kepwareConfigurationClient.SearchTags(
                settings.ChannelName,
                settings.DeviceName,
                settings.Query,
                CancellationToken.None);

            if (result.CommunicationSucceeded && result.HasData)
            {
                foreach (var searchResult in result.Data!)
                {
                    logger.LogInformation($"  {searchResult}");
                }

                logger.LogInformation($"Total hits: {result.Data!.Count}");
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