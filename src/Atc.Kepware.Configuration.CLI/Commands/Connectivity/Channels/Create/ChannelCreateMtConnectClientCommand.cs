namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity.Channels.Create;

public sealed class ChannelCreateMtConnectClientCommand : AsyncCommand<ChannelCreateMtConnectClientCommandSettings>
{
    private readonly ILogger<ChannelCreateMtConnectClientCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public ChannelCreateMtConnectClientCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<ChannelCreateMtConnectClientCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        ChannelCreateMtConnectClientCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        ChannelCreateMtConnectClientCommandSettings settings,
        CancellationToken cancellationToken)
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
                cancellationToken);

            if (!isChannelDefinedResult.CommunicationSucceeded)
            {
                return ConsoleExitStatusCodes.Failure;
            }

            if (isChannelDefinedResult.Data)
            {
                logger.LogWarning("Channel already exists!");
                return ConsoleExitStatusCodes.Success;
            }

            var request = BuildMtConnectClientChannelRequest(settings);
            var result = await kepwareConfigurationClient.CreateMtConnectClientChannel(request, cancellationToken);
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

    private static MtConnectClientChannelRequest BuildMtConnectClientChannelRequest(
        ChannelCreateMtConnectClientCommandSettings settings)
        => new()
        {
            Name = settings.Name,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,
            CaptureDiagnostics = settings.CaptureDiagnostics,
            OptimizationMethod = settings.OptimizationMethod is not null && settings.OptimizationMethod.IsSet
                ? settings.OptimizationMethod.Value
                : ChannelOptimizationMethodType.WriteOnlyLatestValueForAllTags,
            WriteOptimizationDutyCycle = settings.WriteOptimizationDutyCycle,
            NonNormalizedFloatingPointHandling = settings.NonNormalizedFloatingPointHandling is not null && settings.NonNormalizedFloatingPointHandling.IsSet
                ? settings.NonNormalizedFloatingPointHandling.Value
                : ChannelNonNormalizedFloatingPointHandlingType.ReplaceWithZero,
        };
}