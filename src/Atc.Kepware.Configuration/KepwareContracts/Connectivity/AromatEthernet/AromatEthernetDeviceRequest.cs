namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AromatEthernet;

/// <summary>
/// Aromat Ethernet device request - Kepware format.
/// </summary>
internal sealed class AromatEthernetDeviceRequest : DeviceRequestBase, IAromatEthernetDeviceRequest
{
    public AromatEthernetDeviceRequest()
        : base(DriverType.AromatEthernet)
    {
    }

    /// <inheritdoc />
    [Required]
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public AromatEthernetDeviceModelType Model { get; set; } = AromatEthernetDeviceModelType.FP;

    [JsonPropertyName("servermain.DEVICE_ID_FORMAT")]
    public AromatEthernetDeviceIdFormatType IdFormat { get; set; } = AromatEthernetDeviceIdFormatType.Octal;

    /// <inheritdoc />
    [JsonPropertyName("aromat_ethernet.DEVICE_PROTOCOL")]
    public AromatEthernetProtocolType Protocol { get; set; } = AromatEthernetProtocolType.TcpIp;

    /// <inheritdoc />
    [JsonPropertyName("aromat_ethernet.DEVICE_OPEN_METHOD")]
    public AromatEthernetOpenMethodType OpenMethod { get; set; } = AromatEthernetOpenMethodType.Unpassive;

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("aromat_ethernet.DEVICE_SOURCE_PORT_NUMBER")]
    public int SourcePort { get; set; } = 1025;

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("aromat_ethernet.DEVICE_DESTINATION_PORT_NUMBER")]
    public int DestinationPort { get; set; } = 1025;

    /// <inheritdoc />
    [Range(1, 64)]
    [JsonPropertyName("aromat_ethernet.DEVICE_SOURCE_STATION_NUMBER")]
    public int SourceStation { get; set; } = 1;

    /// <inheritdoc />
    [Range(1, 64)]
    [JsonPropertyName("aromat_ethernet.DEVICE_DESTINATION_STATION_NUMBER")]
    public int DestinationStation { get; set; } = 1;

    /// <inheritdoc />
    [JsonPropertyName("aromat_ethernet.DEVICE_REQUEST_SIZE")]
    public AromatEthernetRequestSizeType RequestSize { get; set; } = AromatEthernetRequestSizeType.Bytes64;

    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Model)}: {Model}, {nameof(Protocol)}: {Protocol}";
}