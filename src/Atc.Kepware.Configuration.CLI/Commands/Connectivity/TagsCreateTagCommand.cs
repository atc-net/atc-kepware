namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public class TagsCreateTagCommand : AsyncCommand<TagCreateCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<TagsCreateTagCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public TagsCreateTagCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<TagsCreateTagCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

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

            if (isTagDefinedResult.Data)
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