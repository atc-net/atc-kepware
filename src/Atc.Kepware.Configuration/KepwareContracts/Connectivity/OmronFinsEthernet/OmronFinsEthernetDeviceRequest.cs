namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.OmronFinsEthernet;

/// <summary>
/// Device request properties for the Omron FINS Ethernet driver.
/// </summary>
internal sealed class OmronFinsEthernetDeviceRequest : DeviceRequestBase, IOmronFinsEthernetDeviceRequest
{
    public OmronFinsEthernetDeviceRequest()
        : base(DriverType.OmronFinsEthernet)
    {
    }

    /// <inheritdoc />
    [Required]
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public OmronFinsEthernetDeviceModelType Model { get; set; } = OmronFinsEthernetDeviceModelType.CS1;

    /// <inheritdoc />
    [Range(0, 127)]
    [JsonPropertyName("omron_fins_ethernet.DEVICE_SOURCE_ADDRESS_NUMBER")]
    public int SourceNetworkAddress { get; set; }

    /// <inheritdoc />
    [Range(0, 254)]
    [JsonPropertyName("omron_fins_ethernet.DEVICE_SOURCE_NODE_NUMBER")]
    public int SourceNode { get; set; }

    /// <inheritdoc />
    [Range(0, 127)]
    [JsonPropertyName("omron_fins_ethernet.DEVICE_DESTINATION_ADDRESS_NUMBER")]
    public int DestinationNetworkAddress { get; set; }

    /// <inheritdoc />
    [Range(0, 254)]
    [JsonPropertyName("omron_fins_ethernet.DEVICE_DESTINATION_NODE_NUMBER")]
    public int DestinationNode { get; set; }

    /// <inheritdoc />
    [Range(0, 255)]
    [JsonPropertyName("omron_fins_ethernet.DEVICE_DESTINATION_UNIT_NUMBER")]
    public int DestinationUnit { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("omron_fins_ethernet.DEVICE_RUN_MODE_CS_AND_TS_WRITES")]
    public OmronFinsEthernetCsTsWritesModeType CsTsWritesMode { get; set; } = OmronFinsEthernetCsTsWritesModeType.FailWriteLogMessage;

    /// <inheritdoc />
    [JsonPropertyName("omron_fins_ethernet.DEVICE_REQUEST_SIZE")]
    public OmronFinsEthernetRequestSizeType RequestSize { get; set; } = OmronFinsEthernetRequestSizeType.Bytes512;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Model)}: {Model}";
}
