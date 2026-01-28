namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.MtConnectClient;

/// <summary>
/// Device properties for the MTConnect Client driver.
/// </summary>
public interface IMtConnectClientDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Specify the MTConnect Device ID.
    /// </summary>
    string DeviceId { get; set; }
}
