namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SiemensTcpIpServerEthernet;

/// <summary>
/// Siemens TCP/IP Server Ethernet device request.
/// </summary>
public class SiemensTcpIpServerEthernetDeviceRequest : DeviceRequestBase, ISiemensTcpIpServerEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SiemensTcpIpServerEthernetDeviceRequest"/> class.
    /// </summary>
    public SiemensTcpIpServerEthernetDeviceRequest()
        : base(DriverType.SiemensTcpIpServerEthernet)
    {
    }

    /// <inheritdoc />
    public int RackNumber { get; set; }

    /// <inheritdoc />
    public int CpuSlot { get; set; }

    /// <inheritdoc />
    public SiemensTcpIpServerMaxPduSize MaxPduSize { get; set; } = SiemensTcpIpServerMaxPduSize.Pdu960;
}
