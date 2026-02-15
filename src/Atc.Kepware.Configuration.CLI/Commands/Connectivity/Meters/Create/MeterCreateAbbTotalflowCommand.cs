namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity.Meters.Create;

public sealed class MeterCreateAbbTotalflowCommand : AsyncCommand<MeterCreateCommandBaseSettings>
{
    private readonly ILogger<MeterCreateAbbTotalflowCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public MeterCreateAbbTotalflowCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<MeterCreateAbbTotalflowCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        MeterCreateCommandBaseSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        MeterCreateCommandBaseSettings settings,
        CancellationToken cancellationToken)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            kepwareConfigurationClient.SetConnectionInformation(
                new Uri(settings.ServerUrl),
                settings.UserName!.Value,
                settings.Password!.Value);

            var request = BuildAbbTotalflowMeterRequest(settings);
            var result = await kepwareConfigurationClient.CreateAbbTotalflowMeter(
                request,
                settings.ChannelName,
                settings.DeviceName,
                settings.MeterGroupName,
                cancellationToken);

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

    private static AbbTotalflowMeterRequest BuildAbbTotalflowMeterRequest(
        MeterCreateCommandBaseSettings settings)
        => new()
        {
            Name = settings.Name,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,
        };
}