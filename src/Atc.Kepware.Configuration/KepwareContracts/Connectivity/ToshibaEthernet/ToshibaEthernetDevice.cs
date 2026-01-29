namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.ToshibaEthernet;

/// <summary>
/// Device properties for the Toshiba Ethernet driver.
/// </summary>
internal sealed class ToshibaEthernetDevice : DeviceBase, IToshibaEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = "255.255.255.255";

    [JsonPropertyName("toshiba_ethernet.DEVICE_PORT_NUMBER")]
    public int PortNumber { get; set; } = 1024;

    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}";
}