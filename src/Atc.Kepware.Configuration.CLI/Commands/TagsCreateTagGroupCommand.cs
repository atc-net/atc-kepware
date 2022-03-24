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

        ////try
        ////{
        ////    var userName = settings.UserName;
        ////    var password = settings.Password;

        ////    using var kepwareConfigurationClient = userName is not null && userName.IsSet
        ////        ? new KepwareConfigurationClient(
        ////            logger,
        ////            new Uri(settings.Url),
        ////            userName.Value,
        ////            password!.Value)
        ////        : new KepwareConfigurationClient(
        ////            logger,
        ////            new Uri(settings.Url),
        ////            userName: null,
        ////            password: null);

        ////    var result = await kepwareConfigurationClient.GetChannels(CancellationToken.None);
        ////    if (result.HasCommunicationSucceeded && result.Data is not null)
        ////    {
        ////        foreach (var channelBase in result.Data)
        ////        {
        ////            logger.LogInformation($"{channelBase.Name} - {channelBase.DeviceDriver}");
        ////        }
        ////    }
        ////    else
        ////    {
        ////        return ConsoleExitStatusCodes.Failure;
        ////    }
        ////}
        ////catch (Exception ex)
        ////{
        ////    logger.LogError($"{EmojisConstants.Error} {ex.GetMessage()}");
        ////    return ConsoleExitStatusCodes.Failure;
        ////}

        logger.LogInformation($"{EmojisConstants.Success} Done");
        return ConsoleExitStatusCodes.Success;
    }
}