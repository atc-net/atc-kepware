namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.WagoEthernet;

/// <summary>
/// Defines the Wago Ethernet device request properties.
/// </summary>
public interface IWagoEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device IP address.
    /// </summary>
    /// <remarks>
    /// Format: IP.Address (e.g., "192.168.1.1").
    /// </remarks>
    string DeviceId { get; set; }

    /// <summary>
    /// Gets or sets the device model type.
    /// </summary>
    WagoEthernetDeviceModelType Model { get; set; }

    /// <summary>
    /// Gets or sets the port number.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-65535. Default: 502.
    /// </remarks>
    int PortNumber { get; set; }

    /// <summary>
    /// Gets or sets the maximum input coil size in bits to be used when reading data from this device.
    /// </summary>
    /// <remarks>
    /// Valid range: 8-800 in multiples of 8. Default: 32.
    /// </remarks>
    int InputCoils { get; set; }

    /// <summary>
    /// Gets or sets the maximum output coil size in bits to be used when reading data from this device.
    /// </summary>
    /// <remarks>
    /// Valid range: 8-800 in multiples of 8. Default: 32.
    /// </remarks>
    int OutputCoils { get; set; }

    /// <summary>
    /// Gets or sets the maximum internal register size in words to be used when reading data from this device.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-120. Default: 32.
    /// </remarks>
    int InternalRegisters { get; set; }

    /// <summary>
    /// Gets or sets the maximum holding register size in words to be used when reading data from this device.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-120. Default: 32.
    /// </remarks>
    int HoldingRegisters { get; set; }
}
