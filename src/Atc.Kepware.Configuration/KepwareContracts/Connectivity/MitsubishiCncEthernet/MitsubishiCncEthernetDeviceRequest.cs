namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MitsubishiCncEthernet;

/// <summary>
/// Mitsubishi CNC Ethernet device request - Kepware format.
/// </summary>
internal sealed class MitsubishiCncEthernetDeviceRequest : DeviceRequestBase, IMitsubishiCncEthernetDeviceRequest
{
    public MitsubishiCncEthernetDeviceRequest()
        : base(DriverType.MitsubishiCncEthernet)
    {
    }

    /// <inheritdoc />
    [Required]
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public MitsubishiCncEthernetDeviceModelType Model { get; set; } = MitsubishiCncEthernetDeviceModelType.C64;

    [JsonPropertyName("mitsubishi_cnc_ethernet.DEVICE_FIRST_WORD_LOW")]
    public bool FirstWordLow { get; set; } = true;

    [Range(1, 65535)]
    [JsonPropertyName("mitsubishi_cnc_ethernet.DEVICE_PORT_NUMBER")]
    public int PortNumber { get; set; } = 5001;

    [Range(1, 239)]
    [JsonPropertyName("mitsubishi_cnc_ethernet.DEVICE_SOURCE_NETWORK")]
    public int SourceNetwork { get; set; } = 1;

    [Range(1, 239)]
    [JsonPropertyName("mitsubishi_cnc_ethernet.DEVICE_SOURCE_STATION")]
    public int SourceStation { get; set; } = 1;

    [Range(0, 239)]
    [JsonPropertyName("mitsubishi_cnc_ethernet.DEVICE_DESTINATION_NETWORK")]
    public int DestinationNetwork { get; set; } = 1;

    [Range(0, 239)]
    [JsonPropertyName("mitsubishi_cnc_ethernet.DEVICE_DESTINATION_STATION")]
    public int DestinationStation { get; set; } = 2;

    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Model)}: {Model}";
}