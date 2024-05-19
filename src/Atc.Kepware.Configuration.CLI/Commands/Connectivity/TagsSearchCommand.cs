namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class TagsSearchCommand : AsyncCommand<TagsSearchCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<TagsSearchCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public TagsSearchCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<TagsSearchCommand>();
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

            if (result is { CommunicationSucceeded: true, HasData: true })
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