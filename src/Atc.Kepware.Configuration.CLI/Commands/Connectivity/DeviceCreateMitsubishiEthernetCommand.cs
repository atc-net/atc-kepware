namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class DeviceCreateMitsubishiEthernetCommand : AsyncCommand<DeviceCreateMitsubishiEthernetCommandSettings>
{
    private readonly ILogger<DeviceCreateMitsubishiEthernetCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateMitsubishiEthernetCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<DeviceCreateMitsubishiEthernetCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateMitsubishiEthernetCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateMitsubishiEthernetCommandSettings settings,
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

            var request = BuildMitsubishiEthernetDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateMitsubishiEthernetDevice(
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

    private static MitsubishiEthernetDeviceRequest BuildMitsubishiEthernetDeviceRequest(
        DeviceCreateMitsubishiEthernetCommandSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,

            // Mitsubishi Ethernet Specific Settings
            DeviceId = settings.DeviceId,
            Model = settings.Model is not null && settings.Model.IsSet
                ? settings.Model.Value
                : MitsubishiEthernetDeviceModelType.ASeries,
            FirstWordLow = settings.FirstWordLow,
            IpProtocol = settings.IpProtocol is not null && settings.IpProtocol.IsSet
                ? settings.IpProtocol.Value
                : MitsubishiEthernetIpProtocolType.Udp,
            PortNumber = settings.PortNumber,
            SourcePortNumber = settings.SourcePortNumber,
            Cpu = settings.Cpu is not null && settings.Cpu.IsSet
                ? settings.Cpu.Value
                : MitsubishiEthernetCpuType.LocalCpu,
            ReadBitMemory = settings.ReadBitMemory,
            ReadWordMemory = settings.ReadWordMemory,
            WriteBitSize = settings.WriteBitSize,
            WriteWordSize = settings.WriteWordSize,
            WriteFullStringLength = settings.WriteFullStringLength,
            TimeSyncMethod = settings.TimeSyncMethod is not null && settings.TimeSyncMethod.IsSet
                ? settings.TimeSyncMethod.Value
                : MitsubishiEthernetTimeSyncMethodType.Disabled,
            SyncIntervalMinutes = settings.SyncIntervalMinutes,
        };
}