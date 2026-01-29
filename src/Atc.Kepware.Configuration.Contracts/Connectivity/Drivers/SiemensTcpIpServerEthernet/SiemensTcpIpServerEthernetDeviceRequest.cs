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
    public SiemensTcpIpServerEthernetDeviceModelType Model { get; set; } = SiemensTcpIpServerEthernetDeviceModelType.VirtualS7300;

    /// <inheritdoc />
    public SiemensTcpIpServerEthernetDeviceIdFormatType IdFormat { get; set; } = SiemensTcpIpServerEthernetDeviceIdFormatType.Decimal;

    /// <inheritdoc />
    [Range(0, 7)]
    public int RackNumber { get; set; }

    /// <inheritdoc />
    [Range(0, 31)]
    public int CpuSlot { get; set; }

    /// <inheritdoc />
    public SiemensTcpIpServerMaxPduSize MaxPduSize { get; set; } = SiemensTcpIpServerMaxPduSize.Pdu960;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(RackNumber)}: {RackNumber}, {nameof(CpuSlot)}: {CpuSlot}, {nameof(MaxPduSize)}: {MaxPduSize}";
}
