namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.SiemensTcpIpServerEthernet;

/// <summary>
/// Siemens TCP/IP Server Ethernet device request - Kepware format.
/// </summary>
internal sealed class SiemensTcpIpServerEthernetDeviceRequest : DeviceRequestBase, ISiemensTcpIpServerEthernetDeviceRequest
{
    public SiemensTcpIpServerEthernetDeviceRequest()
        : base(DriverType.SiemensTcpIpServerEthernet)
    {
    }

    [JsonPropertyName("siemens_tcpip_unsolicited_ethernet.DEVICE_CPU_RACK")]
    public int RackNumber { get; set; }

    [JsonPropertyName("siemens_tcpip_unsolicited_ethernet.DEVICE_CPU_SLOT")]
    public int CpuSlot { get; set; }

    [JsonPropertyName("siemens_tcpip_unsolicited_ethernet.DEVICE_MAX_PDU")]
    public SiemensTcpIpServerMaxPduSize MaxPduSize { get; set; } = SiemensTcpIpServerMaxPduSize.Pdu960;

    public override string ToString()
        => $"{base.ToString()}, {nameof(RackNumber)}: {RackNumber}, {nameof(CpuSlot)}: {CpuSlot}, {nameof(MaxPduSize)}: {MaxPduSize}";
}
