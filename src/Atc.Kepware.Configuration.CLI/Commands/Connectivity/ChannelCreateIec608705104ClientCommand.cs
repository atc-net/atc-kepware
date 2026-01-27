namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class ChannelCreateIec608705104ClientCommand : AsyncCommand<ChannelCreateIec608705104ClientCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<ChannelCreateIec608705104ClientCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public ChannelCreateIec608705104ClientCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<ChannelCreateIec608705104ClientCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        ChannelCreateIec608705104ClientCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        ChannelCreateIec608705104ClientCommandSettings settings)
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

            var request = BuildIec608705104ClientChannelRequest(settings);
            var result = await kepwareConfigurationClient.CreateIec608705104ClientChannel(request, CancellationToken.None);
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

    private static Iec608705104ClientChannelRequest BuildIec608705104ClientChannelRequest(
        ChannelCreateIec608705104ClientCommandSettings settings)
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

            // IEC 60870-5-104 Client Specific Settings
            NetworkAdapter = settings.NetworkAdapter is not null && settings.NetworkAdapter.IsSet
                ? settings.NetworkAdapter.Value
                : null,
            DestinationHost = settings.DestinationHost,
            DestinationPort = settings.DestinationPort,
            ConnectTimeout = settings.ConnectTimeout,
            CotSize = settings.CotSize is not null && settings.CotSize.IsSet
                ? settings.CotSize.Value
                : Iec608705104CotSizeType.TwoOctets,
            OriginatorAddress = settings.OriginatorAddress,
            T1 = settings.T1,
            T2 = settings.T2,
            T3 = settings.T3,
            K = settings.K,
            W = settings.W,
            RxBufferSize = settings.RxBufferSize,
            IncrementalTimeout = settings.IncrementalTimeout,
            FirstCharWait = settings.FirstCharWait,
        };
}
