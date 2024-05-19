namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotItem;

public class RestClientIotItemCreateCommand : AsyncCommand<IotItemCreateCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<RestClientIotItemCreateCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public RestClientIotItemCreateCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<RestClientIotItemCreateCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

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
            kepwareConfigurationClient.SetConnectionInformation(
                new Uri(settings.ServerUrl),
                settings.UserName!.Value,
                settings.Password!.Value);

            var isIotAgentDefinedResult = await kepwareConfigurationClient.IsIotAgentDefined(
                settings.IotAgentName,
                CancellationToken.None);

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