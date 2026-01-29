namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SimaticTi505Ethernet;

/// <summary>
/// Simatic/TI 505 Ethernet device.
/// </summary>
public class SimaticTi505EthernetDevice : DeviceBase, ISimaticTi505EthernetDevice
{
    /// <inheritdoc />
    public SimaticTi505EthernetDeviceModelType Model { get; set; } = SimaticTi505EthernetDeviceModelType.Model505Cp2572;

    /// <inheritdoc />
    public SimaticTi505EthernetIpProtocol IpProtocol { get; set; } = SimaticTi505EthernetIpProtocol.Udp;

    /// <inheritdoc />
    public int PortNumber { get; set; } = 1505;

    /// <inheritdoc />
    public SimaticTi505EthernetRequestSize RequestSize { get; set; } = SimaticTi505EthernetRequestSize.Bytes250;

    /// <inheritdoc />
    public SimaticTi505EthernetProtocol Protocol { get; set; } = SimaticTi505EthernetProtocol.CampPlusPackedTaskCode;

    /// <inheritdoc />
    public bool Ti565 { get; set; }

    /// <inheritdoc />
    public SimaticTi505EthernetBitAddressing BitAddressing { get; set; } = SimaticTi505EthernetBitAddressing.ZeroBased;

    /// <inheritdoc />
    public SimaticTi505EthernetBitOrder BitOrderForLoopsAndAlarms { get; set; } = SimaticTi505EthernetBitOrder.Bit01IsLsb;

    /// <inheritdoc />
    public SimaticTi505EthernetBitOrder BitOrderVKWxWyStw { get; set; } = SimaticTi505EthernetBitOrder.Bit01IsLsb;
}