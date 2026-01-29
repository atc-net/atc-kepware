namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.ToshibaEthernet;

/// <summary>
/// Defines the Toshiba Ethernet device request properties.
/// </summary>
public interface IToshibaEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device IP address.
    /// </summary>
    /// <remarks>
    /// Format: IP.Address (e.g., "192.168.1.1").
    /// </remarks>
    string DeviceId { get; set; }

    /// <summary>
    /// Gets or sets the port number.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-65535. Default: 1024.
    /// </remarks>
    int PortNumber { get; set; }
}