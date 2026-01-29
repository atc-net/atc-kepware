namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MitsubishiEthernet;

/// <summary>
/// Represents a Mitsubishi Ethernet device creation request.
/// </summary>
public class MitsubishiEthernetDeviceRequest : DeviceRequestBase, IMitsubishiEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MitsubishiEthernetDeviceRequest"/> class.
    /// </summary>
    public MitsubishiEthernetDeviceRequest()
        : base(DriverType.MitsubishiEthernet)
    {
    }

    /// <summary>
    /// Gets or sets the device IP address with PC number.
    /// </summary>
    /// <remarks>
    /// Format: IP.Address:PCNumber (e.g., "192.168.1.1:0").
    /// </remarks>
    [Required]
    public string DeviceId { get; set; } = "255.255.255.255:0";

    /// <inheritdoc />
    public MitsubishiEthernetDeviceModelType Model { get; set; } = MitsubishiEthernetDeviceModelType.ASeries;

    /// <inheritdoc />
    public bool FirstWordLow { get; set; } = true;

    /// <inheritdoc />
    public MitsubishiEthernetIpProtocolType IpProtocol { get; set; } = MitsubishiEthernetIpProtocolType.Udp;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int PortNumber { get; set; } = 5000;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int SourcePortNumber { get; set; }

    /// <inheritdoc />
    public MitsubishiEthernetCpuType Cpu { get; set; } = MitsubishiEthernetCpuType.LocalCpu;

    /// <inheritdoc />
    [Range(1, 127)]
    public int ReadBitMemory { get; set; } = 127;

    /// <inheritdoc />
    [Range(1, 253)]
    public int ReadWordMemory { get; set; } = 253;

    /// <inheritdoc />
    [Range(1, 80)]
    public int WriteBitSize { get; set; } = 80;

    /// <inheritdoc />
    [Range(1, 40)]
    public int WriteWordSize { get; set; } = 40;

    /// <inheritdoc />
    public bool WriteFullStringLength { get; set; }

    /// <inheritdoc />
    public MitsubishiEthernetTimeSyncMethodType TimeSyncMethod { get; set; } = MitsubishiEthernetTimeSyncMethodType.Disabled;

    /// <inheritdoc />
    public int AbsoluteSyncTime { get; set; }

    /// <inheritdoc />
    [Range(5, 1440)]
    public int SyncIntervalMinutes { get; set; } = 5;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Model)}: {Model}";
}