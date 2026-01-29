namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.BuswareEthernet;

/// <summary>
/// Defines the Busware Ethernet device request properties.
/// </summary>
public interface IBuswareEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device model.
    /// </summary>
    BuswareEthernetDeviceModelType Model { get; set; }

    /// <summary>
    /// Gets or sets the device ID format.
    /// </summary>
    BuswareEthernetDeviceIdFormatType IdFormat { get; set; }

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
    /// Valid range: 0-65535. Default: 502.
    /// </remarks>
    int PortNumber { get; set; }

    /// <summary>
    /// Gets or sets the maximum discrete output block size for reading.
    /// </summary>
    /// <remarks>
    /// Valid range: 8-800. Default: 32.
    /// </remarks>
    int OutputDiscretes { get; set; }

    /// <summary>
    /// Gets or sets the maximum discrete input block size for reading.
    /// </summary>
    /// <remarks>
    /// Valid range: 8-800. Default: 32.
    /// </remarks>
    int InputDiscretes { get; set; }

    /// <summary>
    /// Gets or sets the maximum register output block size for reading.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-120. Default: 32.
    /// </remarks>
    int OutputRegisters { get; set; }

    /// <summary>
    /// Gets or sets the maximum register input block size for reading.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-120. Default: 32.
    /// </remarks>
    int InputRegisters { get; set; }
}
