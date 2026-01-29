namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MitsubishiEthernet;

/// <summary>
/// Device request properties for the Mitsubishi Ethernet driver.
/// </summary>
internal sealed class MitsubishiEthernetDeviceRequest : DeviceRequestBase, IMitsubishiEthernetDeviceRequest
{
    public MitsubishiEthernetDeviceRequest()
        : base(DriverType.MitsubishiEthernet)
    {
    }

    /// <inheritdoc />
    [Required]
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = "255.255.255.255:0";

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public MitsubishiEthernetDeviceModelType Model { get; set; } = MitsubishiEthernetDeviceModelType.ASeries;

    /// <inheritdoc />
    [JsonPropertyName("mitsubishi_ethernet.DEVICE_FIRST_WORD_LOW")]
    public bool FirstWordLow { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("mitsubishi_ethernet.DEVICE_IP_PROTOCOL")]
    public MitsubishiEthernetIpProtocolType IpProtocol { get; set; } = MitsubishiEthernetIpProtocolType.Udp;

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("mitsubishi_ethernet.DEVICE_PORT_NUMBER")]
    public int PortNumber { get; set; } = 5000;

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("mitsubishi_ethernet.DEVICE_SRC_PORT_NUMBER")]
    public int SourcePortNumber { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("mitsubishi_ethernet.DEVICE_CPU")]
    public MitsubishiEthernetCpuType Cpu { get; set; } = MitsubishiEthernetCpuType.LocalCpu;

    /// <inheritdoc />
    [Range(1, 127)]
    [JsonPropertyName("mitsubishi_ethernet.DEVICE_READ_BIT_MEMORY")]
    public int ReadBitMemory { get; set; } = 127;

    /// <inheritdoc />
    [Range(1, 253)]
    [JsonPropertyName("mitsubishi_ethernet.DEVICE_READ_WORD_MEMORY")]
    public int ReadWordMemory { get; set; } = 253;

    /// <inheritdoc />
    [Range(1, 80)]
    [JsonPropertyName("mitsubishi_ethernet.DEVICE_WRITE_BIT_SIZE")]
    public int WriteBitSize { get; set; } = 80;

    /// <inheritdoc />
    [Range(1, 40)]
    [JsonPropertyName("mitsubishi_ethernet.DEVICE_WRITE_WORD_SIZE")]
    public int WriteWordSize { get; set; } = 40;

    /// <inheritdoc />
    [JsonPropertyName("mitsubishi_ethernet.DEVICE_WRITE_FULL_STRING_LENGTH")]
    public bool WriteFullStringLength { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("mitsubishi_ethernet.DEVICE_TIME_SYNC_METHOD")]
    public MitsubishiEthernetTimeSyncMethodType TimeSyncMethod { get; set; } = MitsubishiEthernetTimeSyncMethodType.Disabled;

    /// <inheritdoc />
    [JsonPropertyName("mitsubishi_ethernet.DEVICE_TIME_SYNC_ABSOLUTE_LOCAL")]
    public int AbsoluteSyncTime { get; set; }

    /// <inheritdoc />
    [Range(5, 1440)]
    [JsonPropertyName("mitsubishi_ethernet.DEVICE_TIME_SYNC_INTERVAL_MINUTES")]
    public int SyncIntervalMinutes { get; set; } = 5;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Model)}: {Model}";
}