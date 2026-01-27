namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.GeEthernet;

/// <summary>
/// Defines the GE Ethernet device request properties.
/// </summary>
public interface IGeEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device model.
    /// </summary>
    GeEthernetModel Model { get; set; }
}
