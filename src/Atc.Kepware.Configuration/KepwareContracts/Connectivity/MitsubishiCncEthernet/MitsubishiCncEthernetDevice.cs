namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MitsubishiCncEthernet;

/// <summary>
/// Mitsubishi CNC Ethernet device - Kepware format.
/// </summary>
internal sealed class MitsubishiCncEthernetDevice : DeviceBase, IMitsubishiCncEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public MitsubishiCncEthernetDeviceModelType Model { get; set; }

    [JsonPropertyName("mitsubishi_cnc_ethernet.DEVICE_FIRST_WORD_LOW")]
    public bool FirstWordLow { get; set; } = true;

    [JsonPropertyName("mitsubishi_cnc_ethernet.DEVICE_PORT_NUMBER")]
    public int PortNumber { get; set; } = 5001;

    [JsonPropertyName("mitsubishi_cnc_ethernet.DEVICE_SOURCE_NETWORK")]
    public int SourceNetwork { get; set; } = 1;

    [JsonPropertyName("mitsubishi_cnc_ethernet.DEVICE_SOURCE_STATION")]
    public int SourceStation { get; set; } = 1;

    [JsonPropertyName("mitsubishi_cnc_ethernet.DEVICE_DESTINATION_NETWORK")]
    public int DestinationNetwork { get; set; } = 1;

    [JsonPropertyName("mitsubishi_cnc_ethernet.DEVICE_DESTINATION_STATION")]
    public int DestinationStation { get; set; } = 2;

    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Model)}: {Model}";
}