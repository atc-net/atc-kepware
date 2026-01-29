namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity.Channels.Create;

public sealed class ChannelCreateAlstomRedundantEthernetCommand : AsyncCommand<ChannelCreateAlstomRedundantEthernetCommandSettings>
{
    private readonly ILogger<ChannelCreateAlstomRedundantEthernetCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public ChannelCreateAlstomRedundantEthernetCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<ChannelCreateAlstomRedundantEthernetCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        ChannelCreateAlstomRedundantEthernetCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        ChannelCreateAlstomRedundantEthernetCommandSettings settings,
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

            var request = BuildRequest(settings);
            var result = await kepwareConfigurationClient.CreateAlstomRedundantEthernetChannel(request, cancellationToken);
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

    private static AlstomRedundantEthernetChannelRequest BuildRequest(
        ChannelCreateAlstomRedundantEthernetCommandSettings settings)
    {
        var request = new AlstomRedundantEthernetChannelRequest
        {
            Name = settings.Name,
        };

        if (settings.Description is not null &&
            settings.Description.IsSet)
        {
            request.Description = settings.Description.Value!;
        }

        if (settings.CaptureDiagnostics.HasValue)
        {
            request.CaptureDiagnostics = settings.CaptureDiagnostics.Value;
        }

        if (settings.OptimizationMethod is not null &&
            settings.OptimizationMethod.IsSet)
        {
            request.OptimizationMethod = settings.OptimizationMethod.Value;
        }

        if (settings.WriteOptimizationDutyCycle > 0)
        {
            request.WriteOptimizationDutyCycle = settings.WriteOptimizationDutyCycle;
        }

        if (settings.NonNormalizedFloatingPointHandling is not null &&
            settings.NonNormalizedFloatingPointHandling.IsSet)
        {
            request.NonNormalizedFloatingPointHandling = settings.NonNormalizedFloatingPointHandling.Value;
        }

        if (settings.PrimaryNetworkAdapter is not null &&
            settings.PrimaryNetworkAdapter.IsSet)
        {
            request.PrimaryNetworkAdapter = settings.PrimaryNetworkAdapter.Value;
        }

        if (settings.SecondaryNetworkAdapter is not null &&
            settings.SecondaryNetworkAdapter.IsSet)
        {
            request.SecondaryNetworkAdapter = settings.SecondaryNetworkAdapter.Value;
        }

        return request;
    }
}