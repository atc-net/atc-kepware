namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.SiemensS7PlusEthernet;

/// <summary>
/// Device properties for the Siemens S7 Plus Ethernet driver.
/// </summary>
internal sealed class SiemensS7PlusEthernetDevice : DeviceBase, ISiemensS7PlusEthernetDevice
{
    [JsonPropertyName("siemens_s7_plus_ethernet.DEVICE_PORT_NUMBER")]
    public int Port { get; set; }

    [JsonPropertyName("siemens_s7_plus_ethernet.DEVICE_PLC_PASSWORD")]
    public string? PlcPassword { get; set; }

    [JsonPropertyName("siemens_s7_plus_ethernet.DEVICE_INCLUDE_IDBS_FBS")]
    public bool IncludeIdbsFbs { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(Port)}: {Port}";
}