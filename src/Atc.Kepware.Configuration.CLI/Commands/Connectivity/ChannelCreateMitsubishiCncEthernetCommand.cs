namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class ChannelCreateMitsubishiCncEthernetCommand : AsyncCommand<ChannelCreateMitsubishiCncEthernetCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<ChannelCreateMitsubishiCncEthernetCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public ChannelCreateMitsubishiCncEthernetCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<ChannelCreateMitsubishiCncEthernetCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        ChannelCreateMitsubishiCncEthernetCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        ChannelCreateMitsubishiCncEthernetCommandSettings settings)
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

            if (isChannelDefinedResult.Data)
            {
                logger.LogWarning("Channel already exists!");
                return ConsoleExitStatusCodes.Success;
            }

            var request = BuildMitsubishiCncEthernetChannelRequest(settings);
            var result = await kepwareConfigurationClient.CreateMitsubishiCncEthernetChannel(request, CancellationToken.None);
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

    private static MitsubishiCncEthernetChannelRequest BuildMitsubishiCncEthernetChannelRequest(
        ChannelCreateMitsubishiCncEthernetCommandSettings settings)
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
