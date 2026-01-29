namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.ToyopucEthernet;

/// <summary>
/// Defines the Toyopuc Ethernet device request properties.
/// </summary>
public interface IToyopucEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device IP address.
    /// </summary>
    string DeviceId { get; set; }

    /// <summary>
    /// Gets or sets the device model type.
    /// </summary>
    ToyopucEthernetDeviceModelType Model { get; set; }

    /// <summary>
    /// Gets or sets the port number for the device.
    /// </summary>
    /// <remarks>
    /// Valid range: 1025-65534. Default is 4096.
    /// </remarks>
    int DevicePort { get; set; }
}
