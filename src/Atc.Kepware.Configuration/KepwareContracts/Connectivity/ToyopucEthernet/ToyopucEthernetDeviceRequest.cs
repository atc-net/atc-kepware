namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.ToyopucEthernet;

/// <summary>
/// Device request properties for the Toyopuc Ethernet driver.
/// </summary>
internal sealed class ToyopucEthernetDeviceRequest : DeviceRequestBase, IToyopucEthernetDeviceRequest
{
    public ToyopucEthernetDeviceRequest()
        : base(DriverType.ToyopucEthernet)
    {
    }

    /// <inheritdoc />
    [Required]
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = "127.0.0.1";

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public ToyopucEthernetDeviceModelType Model { get; set; } = ToyopucEthernetDeviceModelType.Pc2_Pc2Interchange;

    /// <inheritdoc />
    [Range(1025, 65534)]
    [JsonPropertyName("toyopuc_ethernet_pc3.DEVICE_PORT_NUMBER")]
    public int DevicePort { get; set; } = 4096;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Model)}: {Model}";
}
