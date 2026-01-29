namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class DeviceCreateSattBusEthernetCommand : AsyncCommand<DeviceCreateSattBusEthernetCommandSettings>
{
    private readonly ILogger<DeviceCreateSattBusEthernetCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateSattBusEthernetCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<DeviceCreateSattBusEthernetCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateSattBusEthernetCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateSattBusEthernetCommandSettings settings,
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

            var request = BuildSattBusEthernetDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateSattBusEthernetDevice(
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

    private static SattBusEthernetDeviceRequest BuildSattBusEthernetDeviceRequest(
        DeviceCreateSattBusEthernetCommandSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,

            // SattBus Ethernet Specific Settings
            DeviceId = settings.DeviceId,
            PortNumber = settings.PortNumber,
            IpProtocol = settings.IpProtocol,
            OverlappedAddressing = settings.OverlappedAddressing,
            WriteToPort = settings.WriteToPort,
            BitOrdering = settings.BitOrdering,
            RegisterBlockSize = settings.RegisterBlockSize,
            IoRamMemoryCellBlockSize = settings.IoRamMemoryCellBlockSize,
        };
}