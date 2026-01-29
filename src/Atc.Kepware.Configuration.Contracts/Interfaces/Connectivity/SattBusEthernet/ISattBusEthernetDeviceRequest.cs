namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.SattBusEthernet;

/// <summary>
/// Defines the SattBus Ethernet device request properties.
/// </summary>
public interface ISattBusEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device IP address.
    /// </summary>
    /// <remarks>
    /// Format: IP.Address (e.g., "192.168.1.1").
    /// </remarks>
    string DeviceId { get; set; }

    /// <summary>
    /// Gets or sets the port number to use when communicating with the device.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-65535. Default: 2999.
    /// </remarks>
    int PortNumber { get; set; }

    /// <summary>
    /// Gets or sets the IP protocol to use when communicating with the device.
    /// </summary>
    SattBusEthernetIpProtocolType IpProtocol { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to use overlapped addressing for double-words.
    /// </summary>
    /// <remarks>
    /// Default: true.
    /// </remarks>
    bool OverlappedAddressing { get; set; }

    /// <summary>
    /// Gets or sets the device port number which will receive messages.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-65535. Default: 2999.
    /// </remarks>
    int WriteToPort { get; set; }

    /// <summary>
    /// Gets or sets the bit ordering for 16 bit memory cell tags (M, MW, XW).
    /// </summary>
    /// <remarks>
    /// Default: MsBit15To0.
    /// </remarks>
    SattBusEthernetBitOrderingType BitOrdering { get; set; }

    /// <summary>
    /// Gets or sets the number of bytes of register data that can be requested at one time.
    /// </summary>
    /// <remarks>
    /// Default: 20 bytes.
    /// </remarks>
    SattBusEthernetRegisterBlockSizeType RegisterBlockSize { get; set; }

    /// <summary>
    /// Gets or sets the number of bytes of I/O RAM/Memory cell data that may be requested at one time.
    /// </summary>
    /// <remarks>
    /// Default: 20 bytes.
    /// </remarks>
    SattBusEthernetIoRamMemoryCellBlockSizeType IoRamMemoryCellBlockSize { get; set; }
}
