namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class ChannelDeleteCommand : AsyncCommand<ChannelDeleteCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<ChannelDeleteCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public ChannelDeleteCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<ChannelDeleteCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        ChannelDeleteCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        ChannelDeleteCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            kepwareConfigurationClient.SetConnectionInformation(
                new Uri(settings.ServerUrl),
                settings.UserName!.Value,
                settings.Password!.Value);

            var isChannelDefinedResult = await kepwareConfigurationClient.IsChannelDefined(
                settings.Name,
                CancellationToken.None);

            if (!isChannelDefinedResult.CommunicationSucceeded)
            {
                return ConsoleExitStatusCodes.Failure;
            }

            if (!isChannelDefinedResult.Data)
            {
                logger.LogWarning("Channel does not exist!");
                return ConsoleExitStatusCodes.Success;
            }

            var result = await kepwareConfigurationClient.DeleteChannel(
                settings.Name,
                CancellationToken.None);

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