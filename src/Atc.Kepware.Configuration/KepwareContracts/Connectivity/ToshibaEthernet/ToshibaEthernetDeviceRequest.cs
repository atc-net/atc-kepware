namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.ToshibaEthernet;

/// <summary>
/// Device request properties for the Toshiba Ethernet driver.
/// </summary>
internal sealed class ToshibaEthernetDeviceRequest : DeviceRequestBase, IToshibaEthernetDeviceRequest
{
    public ToshibaEthernetDeviceRequest()
        : base(DriverType.ToshibaEthernet)
    {
    }

    /// <inheritdoc />
    [Required]
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("toshiba_ethernet.DEVICE_PORT_NUMBER")]
    public int PortNumber { get; set; } = 1024;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}";
}
