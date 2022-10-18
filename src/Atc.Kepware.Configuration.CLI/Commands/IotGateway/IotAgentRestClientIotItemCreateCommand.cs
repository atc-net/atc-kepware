namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway;

public class IotAgentRestClientIotItemCreateCommand : AsyncCommand<IotItemCreateCommandSettings>
{
    private readonly ILogger<IotAgentRestClientIotItemCreateCommand> logger;

    public IotAgentRestClientIotItemCreateCommand(
        ILogger<IotAgentRestClientIotItemCreateCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotItemCreateCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        IotItemCreateCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            var kepwareConfigurationClient = KepwareConfigurationClientBuilder.Build(settings, logger);

            var isIotAgentDefinedResult = await kepwareConfigurationClient.IsIotAgentDefined(
                settings.IotAgentName,
                CancellationToken.None);

            if (isIotAgentDefinedResult.CommunicationSucceeded &&
                !isIotAgentDefinedResult.Data)
            {
                logger.LogWarning("Iot Agent does not exist!");
                return ConsoleExitStatusCodes.Success;
            }

            var request = BuildIotItemRequest(settings);
            var result = await kepwareConfigurationClient.CreateIotAgentRestClientIotItem(
                settings.IotAgentName,
                request,
                CancellationToken.None);

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

    private static IotItemRequest BuildIotItemRequest(
        IotItemCreateCommandSettings settings)
    {
        var request = new IotItemRequest
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