namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SiemensTcpIpEthernet;

/// <summary>
/// Represents a Siemens TCP/IP Ethernet device.
/// </summary>
public class SiemensTcpIpEthernetDevice : DeviceBase, ISiemensTcpIpEthernetDevice
{
    /// <inheritdoc />
    public SiemensTcpIpEthernetDeviceModelType Model { get; set; } = SiemensTcpIpEthernetDeviceModelType.S7300;

    /// <inheritdoc />
    public int Port { get; set; } = 102;

    /// <inheritdoc />
    public int MpiId { get; set; }

    /// <inheritdoc />
    public SiemensTcpIpEthernetMaxPduType MaxPduSize { get; set; } = SiemensTcpIpEthernetMaxPduType.Bytes960;

    /// <inheritdoc />
    public int LocalTsap { get; set; } = 0x4D57;

    /// <inheritdoc />
    public int RemoteTsap { get; set; } = 0x4D57;

    /// <inheritdoc />
    public SiemensTcpIpEthernetLinkType LinkType { get; set; } = SiemensTcpIpEthernetLinkType.PC;

    /// <inheritdoc />
    public int CpuRack { get; set; }

    /// <inheritdoc />
    public int CpuSlot { get; set; } = 2;

    /// <inheritdoc />
    public SiemensTcpIpEthernetByteOrderType ByteOrder { get; set; } = SiemensTcpIpEthernetByteOrderType.BigEndian;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(Port)}: {Port}";
}