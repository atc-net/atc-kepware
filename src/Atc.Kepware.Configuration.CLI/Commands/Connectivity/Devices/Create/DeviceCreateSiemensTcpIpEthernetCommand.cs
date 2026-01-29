namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity.Devices.Create;

public sealed class DeviceCreateSiemensTcpIpEthernetCommand : AsyncCommand<DeviceCreateSiemensTcpIpEthernetCommandSettings>
{
    private readonly ILogger<DeviceCreateSiemensTcpIpEthernetCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateSiemensTcpIpEthernetCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<DeviceCreateSiemensTcpIpEthernetCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateSiemensTcpIpEthernetCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateSiemensTcpIpEthernetCommandSettings settings,
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

            var request = BuildSiemensTcpIpEthernetDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateSiemensTcpIpEthernetDevice(
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

    private static SiemensTcpIpEthernetDeviceRequest BuildSiemensTcpIpEthernetDeviceRequest(
        DeviceCreateSiemensTcpIpEthernetCommandSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,

            // Siemens TCP/IP Ethernet Specific Settings
            DeviceId = settings.DeviceId,
            Model = settings.Model is not null && settings.Model.IsSet
                ? settings.Model.Value
                : SiemensTcpIpEthernetDeviceModelType.S7300,
            Port = settings.Port,
            MpiId = settings.MpiId,
            MaxPduSize = settings.MaxPduSize is not null && settings.MaxPduSize.IsSet
                ? settings.MaxPduSize.Value
                : SiemensTcpIpEthernetMaxPduType.Bytes960,
            LocalTsap = settings.LocalTsap,
            RemoteTsap = settings.RemoteTsap,
            LinkType = settings.LinkType is not null && settings.LinkType.IsSet
                ? settings.LinkType.Value
                : SiemensTcpIpEthernetLinkType.PC,
            CpuRack = settings.CpuRack,
            CpuSlot = settings.CpuSlot,
            ByteOrder = settings.ByteOrder is not null && settings.ByteOrder.IsSet
                ? settings.ByteOrder.Value
                : SiemensTcpIpEthernetByteOrderType.BigEndian,
        };
}