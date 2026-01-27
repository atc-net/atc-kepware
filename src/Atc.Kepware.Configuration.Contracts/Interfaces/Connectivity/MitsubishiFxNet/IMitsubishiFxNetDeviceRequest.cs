namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.MitsubishiFxNet;

/// <summary>
/// Defines the Mitsubishi FX Net device request properties.
/// </summary>
public interface IMitsubishiFxNetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device model.
    /// </summary>
    MitsubishiFxNetModel Model { get; set; }
}
