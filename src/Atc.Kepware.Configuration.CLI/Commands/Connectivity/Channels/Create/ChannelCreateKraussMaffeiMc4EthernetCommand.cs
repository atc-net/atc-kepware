namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity.Channels.Create;

public sealed class ChannelCreateKraussMaffeiMc4EthernetCommand : AsyncCommand<ChannelCreateKraussMaffeiMc4EthernetCommandSettings>
{
    private readonly ILogger<ChannelCreateKraussMaffeiMc4EthernetCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public ChannelCreateKraussMaffeiMc4EthernetCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<ChannelCreateKraussMaffeiMc4EthernetCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        ChannelCreateKraussMaffeiMc4EthernetCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        ChannelCreateKraussMaffeiMc4EthernetCommandSettings settings,
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

            var request = BuildKraussMaffeiMc4EthernetChannelRequest(settings);
            var result = await kepwareConfigurationClient.CreateKraussMaffeiMc4EthernetChannel(request, cancellationToken);
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

    private static KraussMaffeiMc4EthernetChannelRequest BuildKraussMaffeiMc4EthernetChannelRequest(
        ChannelCreateKraussMaffeiMc4EthernetCommandSettings settings)
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