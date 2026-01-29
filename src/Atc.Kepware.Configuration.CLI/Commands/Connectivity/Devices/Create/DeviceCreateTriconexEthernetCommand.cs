namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity.Devices.Create;

public sealed class DeviceCreateTriconexEthernetCommand : AsyncCommand<DeviceCreateTriconexEthernetCommandSettings>
{
    private readonly ILogger<DeviceCreateTriconexEthernetCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateTriconexEthernetCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<DeviceCreateTriconexEthernetCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateTriconexEthernetCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateTriconexEthernetCommandSettings settings,
        CancellationToken cancellationToken)
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
                cancellationToken);

            if (!isDeviceDefinedResult.CommunicationSucceeded)
            {
                return ConsoleExitStatusCodes.Failure;
            }

            if (isDeviceDefinedResult.Data)
            {
                logger.LogWarning("Device already exists!");
                return ConsoleExitStatusCodes.Success;
            }

            var request = BuildTriconexEthernetDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateTriconexEthernetDevice(
                request,
                settings.ChannelName,
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

    private static TriconexEthernetDeviceRequest BuildTriconexEthernetDeviceRequest(
        DeviceCreateTriconexEthernetCommandSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,

            // Triconex Ethernet Specific Settings
            DeviceId = settings.DeviceId,
            PrimaryNetworkCmIp = settings.PrimaryNetworkCmIp,
            SecondaryNetworkCmIp = settings.SecondaryNetworkCmIp is not null && settings.SecondaryNetworkCmIp.IsSet
                ? settings.SecondaryNetworkCmIp.Value
                : "0.0.0.0",
            BinDataUpdatePeriod = settings.BinDataUpdatePeriod,
            SubscriptionInterval = settings.SubscriptionInterval,
            UseTimestampFromDevice = settings.UseTimestampFromDevice,
            VariableImportFile = settings.VariableImportFile is not null && settings.VariableImportFile.IsSet
                ? settings.VariableImportFile.Value
                : null,
            ImportNodeName = settings.ImportNodeName is not null && settings.ImportNodeName.IsSet
                ? settings.ImportNodeName.Value
                : "TRINODE",
            GenerateDeviceSystemTags = settings.GenerateDeviceSystemTags,
            GenerateDriverSystemTags = settings.GenerateDriverSystemTags,
        };
}