// ReSharper disable InvertIf
namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotItem;

public class RestClientIotItemUpdateCommand : AsyncCommand<IotItemUpdateCommandSettings>
{
    private readonly ILogger<RestClientIotItemUpdateCommand> logger;

    public RestClientIotItemUpdateCommand(
        ILogger<RestClientIotItemUpdateCommand> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotItemUpdateCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        IotItemUpdateCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            var kepwareConfigurationClient = KepwareConfigurationClientBuilder.Build(settings, logger);

            var iotAgentResult = await kepwareConfigurationClient.GetIotAgentRestClient(
                settings.IotAgentName,
                CancellationToken.None);

            if (iotAgentResult.CommunicationSucceeded &&
                !iotAgentResult.HasData)
            {
                logger.LogWarning("Iot Agent does not exist!");
                return ConsoleExitStatusCodes.Success;
            }

            var iotItemResult = await kepwareConfigurationClient.GetIotAgentIotItem(
                settings.IotAgentName,
                CommandHelper.GetIotItemInternalNameFromServerTag(settings.ServerTag),
                CancellationToken.None);

            if (iotItemResult.CommunicationSucceeded &&
                !iotItemResult.HasData)
            {
                logger.LogWarning("Iot Agent Iot Item does not exist!");
                return ConsoleExitStatusCodes.Success;
            }

            var (shouldUpdate, request) = BuildIotItemUpdateRequest(
                settings,
                iotItemResult.Data!);

            if (!shouldUpdate)
            {
                logger.LogWarning("Nothing to update on Iot Agent Iot Item!");
                return ConsoleExitStatusCodes.Success;
            }

            var result = await kepwareConfigurationClient.UpdateIotAgentRestClientIotItem(
                settings.IotAgentName,
                CommandHelper.GetIotItemInternalNameFromServerTag(settings.ServerTag),
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

    private static (bool ShouldUpdate, IotItemUpdateRequest Request) BuildIotItemUpdateRequest(
        IotItemUpdateCommandSettings settings,
        Contracts.IotGateway.IotItem existingIotItem)
    {
        var shouldUpdate = false;
        var request = new IotItemUpdateRequest
        {
            ProjectId = existingIotItem.ProjectId,
        };

        if (settings.ScanRate is not null &&
            settings.ScanRate.IsSet &&
            settings.ScanRate.Value != existingIotItem.ScanRate)
        {
            request.ScanRate = settings.ScanRate.Value;
            shouldUpdate = true;
        }

        if (settings.SendEveryScan is not null &&
            settings.SendEveryScan.IsSet &&
            settings.SendEveryScan.Value != existingIotItem.SendEveryScan)
        {
            request.SendEveryScan = settings.SendEveryScan.Value;
            shouldUpdate = true;
        }

        if (settings.DeadBandPercent is not null &&
            settings.DeadBandPercent.IsSet &&
            settings.DeadBandPercent.Value != existingIotItem.DeadBandPercent)
        {
            request.DeadBandPercent = settings.DeadBandPercent.Value;
            shouldUpdate = true;
        }

        if (settings.Enabled is not null &&
            settings.Enabled.IsSet &&
            settings.Enabled.Value != existingIotItem.Enabled)
        {
            request.Enabled = settings.Enabled.Value;
            shouldUpdate = true;
        }

        return (shouldUpdate, request);
    }
}