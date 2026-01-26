namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AllenBradleyEthernet;

/// <summary>
/// Internal model for Allen-Bradley Ethernet device from Kepware API.
/// </summary>
internal sealed class AllenBradleyEthernetDevice : DeviceBase
{
    /// <summary>
    /// Gets or sets the device model.
    /// </summary>
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public AllenBradleyEthernetDeviceModelType Model { get; set; } = AllenBradleyEthernetDeviceModelType.Slc505Open;

    /// <summary>
    /// Gets or sets the TCP/IP port number.
    /// </summary>
    [JsonPropertyName("allenbradley_ethernet.DEVICE_PORT_NUMBER")]
    public int Port { get; set; } = 2222;

    /// <summary>
    /// Gets or sets the request size in bytes.
    /// </summary>
    [JsonPropertyName("allenbradley_ethernet.DEVICE_REQUEST_SIZE")]
    public AllenBradleyEthernetRequestSizeType RequestSize { get; set; } = AllenBradleyEthernetRequestSizeType.Bytes512;

    /// <summary>
    /// Gets or sets the destination node address (DST).
    /// </summary>
    [JsonPropertyName("allenbradley_ethernet.DEVICE_PROTOCOL_NODE_ADDRESS")]
    public int DestinationNodeAddress { get; set; }

    /// <summary>
    /// Gets or sets the slot configuration array.
    /// </summary>
    [JsonPropertyName("allenbradley_ethernet.DEVICE_SLOT_CONFIGURATION")]
    public List<AllenBradleyEthernetSlotConfiguration>? SlotConfiguration { get; set; }
}
