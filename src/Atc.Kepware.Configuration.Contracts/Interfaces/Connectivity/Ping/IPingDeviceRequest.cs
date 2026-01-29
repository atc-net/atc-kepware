namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.Ping;

/// <summary>
/// Defines the Ping device request properties.
/// </summary>
public interface IPingDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device IP address.
    /// </summary>
    /// <remarks>
    /// Format: IP address (e.g., "192.168.1.1").
    /// </remarks>
    string DeviceId { get; set; }
}