namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.SiemensTcpIpEthernet;

/// <summary>
/// Device request properties for the Siemens TCP/IP Ethernet driver.
/// </summary>
internal sealed class SiemensTcpIpEthernetDeviceRequest : DeviceRequestBase, ISiemensTcpIpEthernetDeviceRequest
{
    public SiemensTcpIpEthernetDeviceRequest()
        : base(DriverType.SiemensTcpIpEthernet)
    {
    }

    /// <inheritdoc />
    [Required]
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public SiemensTcpIpEthernetDeviceModelType Model { get; set; } = SiemensTcpIpEthernetDeviceModelType.S7300;

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("siemens_tcpip_ethernet.DEVICE_COMMUNICATIONS_PORT_NUMBER")]
    public int Port { get; set; } = 102;

    /// <inheritdoc />
    [Range(0, 126)]
    [JsonPropertyName("siemens_tcpip_ethernet.DEVICE_COMMUNICATIONS_MPI_ID")]
    public int MpiId { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("siemens_tcpip_ethernet.DEVICE_S7_COMMUNICATIONS_MAX_PDU")]
    public SiemensTcpIpEthernetMaxPduType MaxPduSize { get; set; } = SiemensTcpIpEthernetMaxPduType.Bytes960;

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("siemens_tcpip_ethernet.DEVICE_S7_COMMUNICATIONS_200_LOCAL_TSAP")]
    public int LocalTsap { get; set; } = 0x4D57;

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("siemens_tcpip_ethernet.DEVICE_S7_COMMUNICATIONS_200_REMOTE_TSAP")]
    public int RemoteTsap { get; set; } = 0x4D57;

    /// <inheritdoc />
    [JsonPropertyName("siemens_tcpip_ethernet.DEVICE_S7_COMMUNICATIONS_300_400_1200_1500_LINK_TYPE")]
    public SiemensTcpIpEthernetLinkType LinkType { get; set; } = SiemensTcpIpEthernetLinkType.PC;

    /// <inheritdoc />
    [Range(0, 7)]
    [JsonPropertyName("siemens_tcpip_ethernet.DEVICE_S7_COMMUNICATIONS_CPU_RACK")]
    public int CpuRack { get; set; }

    /// <inheritdoc />
    [Range(1, 31)]
    [JsonPropertyName("siemens_tcpip_ethernet.DEVICE_S7_COMMUNICATIONS_CPU_SLOT")]
    public int CpuSlot { get; set; } = 2;

    /// <inheritdoc />
    [JsonPropertyName("siemens_tcpip_ethernet.DEVICE_ADDRESSING_BYTE_ORDER")]
    public SiemensTcpIpEthernetByteOrderType ByteOrder { get; set; } = SiemensTcpIpEthernetByteOrderType.BigEndian;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Model)}: {Model}, {nameof(Port)}: {Port}";
}