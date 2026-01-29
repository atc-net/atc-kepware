namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AromatEthernet;

/// <summary>
/// Aromat Ethernet device - Kepware format.
/// </summary>
internal sealed class AromatEthernetDevice : DeviceBase, IAromatEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public AromatEthernetDeviceModelType Model { get; set; }

    [JsonPropertyName("servermain.DEVICE_ID_FORMAT")]
    public AromatEthernetDeviceIdFormatType IdFormat { get; set; } = AromatEthernetDeviceIdFormatType.Octal;

    [JsonPropertyName("aromat_ethernet.DEVICE_PROTOCOL")]
    public AromatEthernetProtocolType Protocol { get; set; }

    [JsonPropertyName("aromat_ethernet.DEVICE_OPEN_METHOD")]
    public AromatEthernetOpenMethodType OpenMethod { get; set; }

    [JsonPropertyName("aromat_ethernet.DEVICE_SOURCE_PORT_NUMBER")]
    public int SourcePort { get; set; }

    [JsonPropertyName("aromat_ethernet.DEVICE_DESTINATION_PORT_NUMBER")]
    public int DestinationPort { get; set; }

    [JsonPropertyName("aromat_ethernet.DEVICE_SOURCE_STATION_NUMBER")]
    public int SourceStation { get; set; }

    [JsonPropertyName("aromat_ethernet.DEVICE_DESTINATION_STATION_NUMBER")]
    public int DestinationStation { get; set; }

    [JsonPropertyName("aromat_ethernet.DEVICE_REQUEST_SIZE")]
    public AromatEthernetRequestSizeType RequestSize { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Model)}: {Model}, {nameof(Protocol)}: {Protocol}";
}
