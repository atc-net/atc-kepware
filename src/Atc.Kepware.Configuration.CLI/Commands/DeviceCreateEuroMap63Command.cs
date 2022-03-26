namespace Atc.Kepware.Configuration.CLI.Commands;

public class DeviceCreateEuroMap63Command : AsyncCommand<DeviceCreateCommandBaseSettings>
{
    private readonly ILogger<DeviceCreateEuroMap63Command> logger;

    public DeviceCreateEuroMap63Command(
        ILogger<DeviceCreateEuroMap63Command> logger)
        => this.logger = logger;

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateCommandBaseSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateCommandBaseSettings settings)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            var kepwareConfigurationClient = KepwareConfigurationClientBuilder.Build(settings, logger);

            var isDeviceDefined = await kepwareConfigurationClient.IsDeviceDefined(
                settings.ChannelName,
                settings.DeviceName,
                CancellationToken.None);

            if (isDeviceDefined)
            {
                logger.LogWarning("Device already exists!");
                return ConsoleExitStatusCodes.Success;
            }

            var request = BuildEuroMap63DeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateEuroMap63Device(
                request,
                settings.ChannelName,
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

    private static EuroMap63DeviceRequest BuildEuroMap63DeviceRequest(
        DeviceCreateCommandBaseSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,
            SessionFilePath = settings.SessionFilePath,
        };
}