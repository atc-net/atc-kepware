namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.SiemensTcpIpEthernet;

/// <summary>
/// Device properties for the Siemens TCP/IP Ethernet driver.
/// </summary>
internal sealed class SiemensTcpIpEthernetDevice : DeviceBase, ISiemensTcpIpEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public SiemensTcpIpEthernetDeviceModelType Model { get; set; }

    [JsonPropertyName("siemens_tcpip_ethernet.DEVICE_COMMUNICATIONS_PORT_NUMBER")]
    public int Port { get; set; }

    [JsonPropertyName("siemens_tcpip_ethernet.DEVICE_COMMUNICATIONS_MPI_ID")]
    public int MpiId { get; set; }

    [JsonPropertyName("siemens_tcpip_ethernet.DEVICE_S7_COMMUNICATIONS_MAX_PDU")]
    public SiemensTcpIpEthernetMaxPduType MaxPduSize { get; set; }

    [JsonPropertyName("siemens_tcpip_ethernet.DEVICE_S7_COMMUNICATIONS_200_LOCAL_TSAP")]
    public int LocalTsap { get; set; }

    [JsonPropertyName("siemens_tcpip_ethernet.DEVICE_S7_COMMUNICATIONS_200_REMOTE_TSAP")]
    public int RemoteTsap { get; set; }

    [JsonPropertyName("siemens_tcpip_ethernet.DEVICE_S7_COMMUNICATIONS_300_400_1200_1500_LINK_TYPE")]
    public SiemensTcpIpEthernetLinkType LinkType { get; set; }

    [JsonPropertyName("siemens_tcpip_ethernet.DEVICE_S7_COMMUNICATIONS_CPU_RACK")]
    public int CpuRack { get; set; }

    [JsonPropertyName("siemens_tcpip_ethernet.DEVICE_S7_COMMUNICATIONS_CPU_SLOT")]
    public int CpuSlot { get; set; }

    [JsonPropertyName("siemens_tcpip_ethernet.DEVICE_ADDRESSING_BYTE_ORDER")]
    public SiemensTcpIpEthernetByteOrderType ByteOrder { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(Port)}: {Port}";
}
