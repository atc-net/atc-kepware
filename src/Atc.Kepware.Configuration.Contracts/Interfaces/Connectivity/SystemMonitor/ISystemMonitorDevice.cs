namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.SystemMonitor;

/// <summary>
/// Device properties for the System Monitor driver.
/// </summary>
public interface ISystemMonitorDevice : IDeviceBase
{
    /// <summary>
    /// The device identifier string (hostname or IP address of the target system to monitor).
    /// </summary>
    string DeviceId { get; set; }

    /// <summary>
    /// The number of tags the System Monitor Driver will update at once.
    /// </summary>
    int QuerySize { get; set; }
}