namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SiemensTcpIpServerEthernet;

/// <summary>
/// Siemens TCP/IP Server Ethernet device.
/// </summary>
public class SiemensTcpIpServerEthernetDevice : DeviceBase, ISiemensTcpIpServerEthernetDevice
{
    /// <inheritdoc />
    public SiemensTcpIpServerEthernetDeviceModelType Model { get; set; }

    /// <inheritdoc />
    public SiemensTcpIpServerEthernetDeviceIdFormatType IdFormat { get; set; } = SiemensTcpIpServerEthernetDeviceIdFormatType.Decimal;

    /// <inheritdoc />
    public int RackNumber { get; set; }

    /// <inheritdoc />
    public int CpuSlot { get; set; }

    /// <inheritdoc />
    public SiemensTcpIpServerMaxPduSize MaxPduSize { get; set; } = SiemensTcpIpServerMaxPduSize.Pdu960;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(RackNumber)}: {RackNumber}, {nameof(CpuSlot)}: {CpuSlot}, {nameof(MaxPduSize)}: {MaxPduSize}";
}
