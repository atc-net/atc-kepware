namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class ChannelCreateBeckhoffTwinCatCommand : AsyncCommand<ChannelCreateBeckhoffTwinCatCommandSettings>
{
    private readonly ILogger<ChannelCreateBeckhoffTwinCatCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public ChannelCreateBeckhoffTwinCatCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<ChannelCreateBeckhoffTwinCatCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        ChannelCreateBeckhoffTwinCatCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        ChannelCreateBeckhoffTwinCatCommandSettings settings,
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

            var request = BuildBeckhoffTwinCatChannelRequest(settings);
            var result = await kepwareConfigurationClient.CreateBeckhoffTwinCatChannel(request, cancellationToken);
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

    private static BeckhoffTwinCatChannelRequest BuildBeckhoffTwinCatChannelRequest(
        ChannelCreateBeckhoffTwinCatCommandSettings settings)
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
            NetworkAdapter = settings.NetworkAdapter is not null && settings.NetworkAdapter.IsSet
                ? settings.NetworkAdapter.Value
                : null,
        };
}