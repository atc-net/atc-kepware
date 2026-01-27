namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class DeviceCreateMitsubishiCncEthernetCommand : AsyncCommand<DeviceCreateMitsubishiCncEthernetCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<DeviceCreateMitsubishiCncEthernetCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateMitsubishiCncEthernetCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<DeviceCreateMitsubishiCncEthernetCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateMitsubishiCncEthernetCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateMitsubishiCncEthernetCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            kepwareConfigurationClient.SetConnectionInformation(
                new Uri(settings.ServerUrl),
                settings.UserName!.Value,
                settings.Password!.Value);

            var isDeviceDefinedResult = await kepwareConfigurationClient.IsDeviceDefined(
                settings.ChannelName,
                settings.DeviceName,
                CancellationToken.None);

            if (!isDeviceDefinedResult.CommunicationSucceeded)
            {
                return ConsoleExitStatusCodes.Failure;
            }

            if (isDeviceDefinedResult.Data)
            {
                logger.LogWarning("Device already exists!");
                return ConsoleExitStatusCodes.Success;
            }

            var request = BuildMitsubishiCncEthernetDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateMitsubishiCncEthernetDevice(
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

    private static MitsubishiCncEthernetDeviceRequest BuildMitsubishiCncEthernetDeviceRequest(
        DeviceCreateMitsubishiCncEthernetCommandSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,

            // Mitsubishi CNC Ethernet Specific Settings
            FirstWordLow = settings.FirstWordLow,
            PortNumber = settings.PortNumber,
            SourceNetwork = settings.SourceNetwork,
            SourceStation = settings.SourceStation,
            DestinationNetwork = settings.DestinationNetwork,
            DestinationStation = settings.DestinationStation,
        };
}
