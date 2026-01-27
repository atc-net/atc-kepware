namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SiemensTcpIpServerEthernet;

/// <summary>
/// Siemens TCP/IP Server Ethernet device.
/// </summary>
public class SiemensTcpIpServerEthernetDevice : DeviceBase, ISiemensTcpIpServerEthernetDevice
{
    /// <inheritdoc />
    public int RackNumber { get; set; }

    /// <inheritdoc />
    public int CpuSlot { get; set; }

    /// <inheritdoc />
    public SiemensTcpIpServerMaxPduSize MaxPduSize { get; set; } = SiemensTcpIpServerMaxPduSize.Pdu960;
}
