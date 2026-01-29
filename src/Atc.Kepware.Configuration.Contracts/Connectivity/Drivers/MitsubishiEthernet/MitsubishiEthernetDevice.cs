namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MitsubishiEthernet;

/// <summary>
/// Represents a Mitsubishi Ethernet device.
/// </summary>
public class MitsubishiEthernetDevice : DeviceBase, IMitsubishiEthernetDevice
{
    /// <inheritdoc />
    public string DeviceId { get; set; } = "255.255.255.255:0";

    /// <inheritdoc />
    public MitsubishiEthernetDeviceModelType Model { get; set; } = MitsubishiEthernetDeviceModelType.ASeries;

    /// <inheritdoc />
    public bool FirstWordLow { get; set; } = true;

    /// <inheritdoc />
    public MitsubishiEthernetIpProtocolType IpProtocol { get; set; } = MitsubishiEthernetIpProtocolType.Udp;

    /// <inheritdoc />
    public int PortNumber { get; set; } = 5000;

    /// <inheritdoc />
    public int SourcePortNumber { get; set; }

    /// <inheritdoc />
    public MitsubishiEthernetCpuType Cpu { get; set; } = MitsubishiEthernetCpuType.LocalCpu;

    /// <inheritdoc />
    public int ReadBitMemory { get; set; } = 127;

    /// <inheritdoc />
    public int ReadWordMemory { get; set; } = 253;

    /// <inheritdoc />
    public int WriteBitSize { get; set; } = 80;

    /// <inheritdoc />
    public int WriteWordSize { get; set; } = 40;

    /// <inheritdoc />
    public bool WriteFullStringLength { get; set; }

    /// <inheritdoc />
    public MitsubishiEthernetTimeSyncMethodType TimeSyncMethod { get; set; } = MitsubishiEthernetTimeSyncMethodType.Disabled;

    /// <inheritdoc />
    public int AbsoluteSyncTime { get; set; }

    /// <inheritdoc />
    public int SyncIntervalMinutes { get; set; } = 5;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Model)}: {Model}";
}
