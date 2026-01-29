namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.SystemMonitor;

/// <summary>
/// Device properties for the System Monitor driver.
/// </summary>
public interface ISystemMonitorDeviceRequest
{
    /// <summary>
    /// Specify the device's driver-specific station or node.
    /// This is typically the hostname or IP address of the system to monitor.
    /// </summary>
    string DeviceId { get; set; }

    /// <summary>
    /// Specify how many tags the System Monitor Driver will update at once.
    /// Although the Performance Data Helper functions can be CPU intensive for large projects,
    /// it can be offset by reducing (or in some cases, increasing) the Query Size.
    /// </summary>
    int QuerySize { get; set; }
}
