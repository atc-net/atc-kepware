namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.SimaticTi505Ethernet;

/// <summary>
/// Interface for Simatic/TI 505 Ethernet device.
/// </summary>
public interface ISimaticTi505EthernetDevice : IDeviceBase
{
    /// <summary>
    /// Gets or sets the IP protocol (UDP or TCP).
    /// </summary>
    SimaticTi505EthernetIpProtocol IpProtocol { get; set; }

    /// <summary>
    /// Gets or sets the port number that the remote device is configured to use.
    /// </summary>
    int PortNumber { get; set; }

    /// <summary>
    /// Gets or sets the number of bytes that may be requested from a device at one time.
    /// </summary>
    SimaticTi505EthernetRequestSize RequestSize { get; set; }

    /// <summary>
    /// Gets or sets the 505 protocol (CAMP or CAMP Plus Packed Task Code).
    /// </summary>
    SimaticTi505EthernetProtocol Protocol { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the TI565 PLC is being used.
    /// </summary>
    bool Ti565 { get; set; }

    /// <summary>
    /// Gets or sets the 0/1-based bit addressing.
    /// </summary>
    SimaticTi505EthernetBitAddressing BitAddressing { get; set; }

    /// <summary>
    /// Gets or sets the bit order for loop and alarm address types.
    /// </summary>
    SimaticTi505EthernetBitOrder BitOrderForLoopsAndAlarms { get; set; }

    /// <summary>
    /// Gets or sets the bit order for V, K, WX, WY, and STW address types.
    /// </summary>
    SimaticTi505EthernetBitOrder BitOrderVKWxWyStw { get; set; }
}
