namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.SiemensTcpIpServerEthernet;

/// <summary>
/// Siemens TCP/IP Server Ethernet device - Kepware format.
/// </summary>
internal sealed class SiemensTcpIpServerEthernetDevice : DeviceBase, ISiemensTcpIpServerEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public SiemensTcpIpServerEthernetDeviceModelType Model { get; set; }

    [JsonPropertyName("servermain.DEVICE_ID_FORMAT")]
    public SiemensTcpIpServerEthernetDeviceIdFormatType IdFormat { get; set; } = SiemensTcpIpServerEthernetDeviceIdFormatType.Decimal;

    [JsonPropertyName("siemens_tcpip_unsolicited_ethernet.DEVICE_CPU_RACK")]
    public int RackNumber { get; set; }

    [JsonPropertyName("siemens_tcpip_unsolicited_ethernet.DEVICE_CPU_SLOT")]
    public int CpuSlot { get; set; }

    [JsonPropertyName("siemens_tcpip_unsolicited_ethernet.DEVICE_MAX_PDU")]
    public SiemensTcpIpServerMaxPduSize MaxPduSize { get; set; } = SiemensTcpIpServerMaxPduSize.Pdu960;

    public override string ToString()
        => $"{base.ToString()}, {nameof(RackNumber)}: {RackNumber}, {nameof(CpuSlot)}: {CpuSlot}, {nameof(MaxPduSize)}: {MaxPduSize}";
}
