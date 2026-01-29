namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class DeviceCreateOmronFinsEthernetCommand : AsyncCommand<DeviceCreateOmronFinsEthernetCommandSettings>
{
    private readonly ILogger<DeviceCreateOmronFinsEthernetCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateOmronFinsEthernetCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<DeviceCreateOmronFinsEthernetCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateOmronFinsEthernetCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateOmronFinsEthernetCommandSettings settings,
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

            var request = BuildOmronFinsEthernetDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateOmronFinsEthernetDevice(
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

    private static OmronFinsEthernetDeviceRequest BuildOmronFinsEthernetDeviceRequest(
        DeviceCreateOmronFinsEthernetCommandSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,

            // Omron FINS Ethernet Specific Settings
            DeviceId = settings.DeviceId,
            Model = settings.Model is not null && settings.Model.IsSet
                ? settings.Model.Value
                : OmronFinsEthernetDeviceModelType.CS1,
            SourceNetworkAddress = settings.SourceNetworkAddress,
            SourceNode = settings.SourceNode,
            DestinationNetworkAddress = settings.DestinationNetworkAddress,
            DestinationNode = settings.DestinationNode,
            DestinationUnit = settings.DestinationUnit,
            CsTsWritesMode = settings.CsTsWritesMode is not null && settings.CsTsWritesMode.IsSet
                ? settings.CsTsWritesMode.Value
                : OmronFinsEthernetCsTsWritesModeType.FailWriteLogMessage,
            RequestSize = settings.RequestSize is not null && settings.RequestSize.IsSet
                ? settings.RequestSize.Value
                : OmronFinsEthernetRequestSizeType.Bytes512,
        };
}