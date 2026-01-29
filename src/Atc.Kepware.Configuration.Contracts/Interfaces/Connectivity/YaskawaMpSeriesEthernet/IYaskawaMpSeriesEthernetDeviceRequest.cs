namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.YaskawaMpSeriesEthernet;

/// <summary>
/// Defines the Yaskawa MP Series Ethernet device request properties.
/// </summary>
public interface IYaskawaMpSeriesEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device IP address.
    /// </summary>
    /// <remarks>
    /// Format: IP.Address (e.g., "192.168.1.1").
    /// </remarks>
    string DeviceId { get; set; }

    /// <summary>
    /// Gets or sets the TCP/IP port number that the remote device is configured to use.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-65535. Default: 502.
    /// </remarks>
    int PortNumber { get; set; }

    /// <summary>
    /// Gets or sets the Input Bits block size when reading data from this device.
    /// </summary>
    /// <remarks>
    /// Input Bits must be a multiple of 8. Valid range: 8-800. Default: 32.
    /// </remarks>
    int InputBits { get; set; }

    /// <summary>
    /// Gets or sets the Output Bits block size when reading data from this device.
    /// </summary>
    /// <remarks>
    /// Output Bits must be a multiple of 8. Valid range: 8-800. Default: 32.
    /// </remarks>
    int OutputBits { get; set; }

    /// <summary>
    /// Gets or sets the number of Input Registers (in words) that will be read from the device in a single request.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-120. Default: 32.
    /// </remarks>
    int InputWords { get; set; }

    /// <summary>
    /// Gets or sets the number of Output Registers (in words) that will be read from the device in a single request.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-120. Default: 32.
    /// </remarks>
    int OutputWords { get; set; }
}