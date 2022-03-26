namespace Atc.Kepware.Configuration.CLI.Commands;

public class ChannelCreateEuroMap63Command : AsyncCommand<ChannelCreateCommandBaseSettings>
{
    private readonly ILogger<ChannelCreateEuroMap63Command> logger;

    public ChannelCreateEuroMap63Command(
        ILogger<ChannelCreateEuroMap63Command> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        ChannelCreateCommandBaseSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        ChannelCreateCommandBaseSettings settings)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            var kepwareConfigurationClient = KepwareConfigurationClientBuilder.Build(settings, logger);

            var isChannelDefined = await kepwareConfigurationClient.IsChannelDefined(
                settings.Name,
                CancellationToken.None);

            if (isChannelDefined)
            {
                logger.LogWarning("Channel already exists!");
                return ConsoleExitStatusCodes.Success;
            }

            var request = BuildEuroMap63ChannelRequest(settings);
            var result = await kepwareConfigurationClient.CreateEuroMap63Channel(request, CancellationToken.None);

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

    private static EuroMap63ChannelRequest BuildEuroMap63ChannelRequest(
        ChannelCreateCommandBaseSettings settings)
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
            NonNormalizedFloatingPointHandling =
                settings.NonNormalizedFloatingPointHandling is not null && settings.NonNormalizedFloatingPointHandling.IsSet
                    ? settings.NonNormalizedFloatingPointHandling.Value
                    : ChannelNonNormalizedFloatingPointHandlingType.ReplaceWithZero,
        };
}