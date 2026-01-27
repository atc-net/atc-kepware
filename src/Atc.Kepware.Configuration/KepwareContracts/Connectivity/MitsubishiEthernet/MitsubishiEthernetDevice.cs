namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MitsubishiEthernet;

/// <summary>
/// Device properties for the Mitsubishi Ethernet driver.
/// </summary>
internal sealed class MitsubishiEthernetDevice : DeviceBase, IMitsubishiEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public MitsubishiEthernetDeviceModelType Model { get; set; }

    [JsonPropertyName("mitsubishi_ethernet.DEVICE_FIRST_WORD_LOW")]
    public bool FirstWordLow { get; set; }

    [JsonPropertyName("mitsubishi_ethernet.DEVICE_IP_PROTOCOL")]
    public MitsubishiEthernetIpProtocolType IpProtocol { get; set; }

    [JsonPropertyName("mitsubishi_ethernet.DEVICE_PORT_NUMBER")]
    public int PortNumber { get; set; }

    [JsonPropertyName("mitsubishi_ethernet.DEVICE_SRC_PORT_NUMBER")]
    public int SourcePortNumber { get; set; }

    [JsonPropertyName("mitsubishi_ethernet.DEVICE_CPU")]
    public MitsubishiEthernetCpuType Cpu { get; set; }

    [JsonPropertyName("mitsubishi_ethernet.DEVICE_READ_BIT_MEMORY")]
    public int ReadBitMemory { get; set; }

    [JsonPropertyName("mitsubishi_ethernet.DEVICE_READ_WORD_MEMORY")]
    public int ReadWordMemory { get; set; }

    [JsonPropertyName("mitsubishi_ethernet.DEVICE_WRITE_BIT_SIZE")]
    public int WriteBitSize { get; set; }

    [JsonPropertyName("mitsubishi_ethernet.DEVICE_WRITE_WORD_SIZE")]
    public int WriteWordSize { get; set; }

    [JsonPropertyName("mitsubishi_ethernet.DEVICE_WRITE_FULL_STRING_LENGTH")]
    public bool WriteFullStringLength { get; set; }

    [JsonPropertyName("mitsubishi_ethernet.DEVICE_TIME_SYNC_METHOD")]
    public MitsubishiEthernetTimeSyncMethodType TimeSyncMethod { get; set; }

    [JsonPropertyName("mitsubishi_ethernet.DEVICE_TIME_SYNC_INTERVAL_MINUTES")]
    public int SyncIntervalMinutes { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Model)}: {Model}";
}
