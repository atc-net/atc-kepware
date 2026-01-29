namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotItem.Create;

public sealed class MqttClientIotItemCreateCommand : AsyncCommand<IotItemCreateCommandSettings>
{
    private readonly ILogger<MqttClientIotItemCreateCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public MqttClientIotItemCreateCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<MqttClientIotItemCreateCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotItemCreateCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        IotItemCreateCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            kepwareConfigurationClient.SetConnectionInformation(
                new Uri(settings.ServerUrl),
                settings.UserName!.Value,
                settings.Password!.Value);

            var isIotAgentDefinedResult = await kepwareConfigurationClient.IsIotAgentDefined(
                settings.IotAgentName,
                cancellationToken);

            if (!isIotAgentDefinedResult.CommunicationSucceeded)
            {
                return ConsoleExitStatusCodes.Failure;
            }

            if (!isIotAgentDefinedResult.Data)
            {
                logger.LogWarning("Iot Agent does not exist!");
                return ConsoleExitStatusCodes.Success;
            }

            var request = BuildIotItemCreateRequest(settings);
            var result = await kepwareConfigurationClient.CreateIotAgentMqttClientIotItem(
                settings.IotAgentName,
                request,
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

    private static IotItemCreateRequest BuildIotItemCreateRequest(
        IotItemCreateCommandSettings settings)
    {
        var request = new IotItemCreateRequest
        {
            ServerTag = settings.ServerTag,
            ScanRate = settings.ScanRate,
        };

        if (settings.SendEveryScan is not null)
        {
            request.SendEveryScan = settings.SendEveryScan.Value;
        }

        if (settings.DeadBandPercent is not null &&
            settings.DeadBandPercent.IsSet)
        {
            request.DeadBandPercent = settings.DeadBandPercent.Value;
        }

        request.Enabled = settings.Enabled is null || settings.Enabled.Value;

        return request;
    }
}