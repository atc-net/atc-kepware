namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.GeEthernetGlobalData;

/// <summary>
/// Defines the GE Ethernet Global Data device request properties.
/// </summary>
public interface IGeEthernetGlobalDataDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device model.
    /// </summary>
    GeEthernetGlobalDataModel Model { get; set; }
}
