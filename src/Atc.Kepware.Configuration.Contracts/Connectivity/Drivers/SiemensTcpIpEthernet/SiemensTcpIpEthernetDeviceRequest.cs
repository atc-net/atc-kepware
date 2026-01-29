namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SiemensTcpIpEthernet;

/// <summary>
/// Represents a Siemens TCP/IP Ethernet device creation request.
/// </summary>
public class SiemensTcpIpEthernetDeviceRequest : DeviceRequestBase, ISiemensTcpIpEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SiemensTcpIpEthernetDeviceRequest"/> class.
    /// </summary>
    public SiemensTcpIpEthernetDeviceRequest()
        : base(DriverType.SiemensTcpIpEthernet)
    {
    }

    /// <summary>
    /// Gets or sets the device IP address.
    /// </summary>
    [Required]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    public SiemensTcpIpEthernetDeviceModelType Model { get; set; } = SiemensTcpIpEthernetDeviceModelType.S7300;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int Port { get; set; } = 102;

    /// <inheritdoc />
    [Range(0, 126)]
    public int MpiId { get; set; }

    /// <inheritdoc />
    public SiemensTcpIpEthernetMaxPduType MaxPduSize { get; set; } = SiemensTcpIpEthernetMaxPduType.Bytes960;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int LocalTsap { get; set; } = 0x4D57;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int RemoteTsap { get; set; } = 0x4D57;

    /// <inheritdoc />
    public SiemensTcpIpEthernetLinkType LinkType { get; set; } = SiemensTcpIpEthernetLinkType.PC;

    /// <inheritdoc />
    [Range(0, 7)]
    public int CpuRack { get; set; }

    /// <inheritdoc />
    [Range(1, 31)]
    public int CpuSlot { get; set; } = 2;

    /// <inheritdoc />
    public SiemensTcpIpEthernetByteOrderType ByteOrder { get; set; } = SiemensTcpIpEthernetByteOrderType.BigEndian;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Model)}: {Model}, {nameof(Port)}: {Port}";
}