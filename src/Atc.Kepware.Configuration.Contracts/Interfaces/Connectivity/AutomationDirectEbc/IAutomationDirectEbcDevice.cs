namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.AutomationDirectEbc;

/// <summary>
/// Interface for AutomationDirect EBC device.
/// </summary>
public interface IAutomationDirectEbcDevice : IDeviceBase
{
    /// <summary>
    /// Gets or sets the device model.
    /// </summary>
    AutomationDirectEbcDeviceModel Model { get; set; }

    /// <summary>
    /// Gets or sets the device ID (IP address format, e.g., "255.255.255.255").
    /// </summary>
    string DeviceId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the link watchdog is enabled.
    /// When enabled, outputs are turned off if link communication is lost.
    /// Only applicable for non-GS device models.
    /// </summary>
    bool UseLinkWatchdog { get; set; }

    /// <summary>
    /// Gets or sets the watchdog timeout in milliseconds.
    /// Time after loss of link communication before outputs are turned off.
    /// Range: 60-32767ms.
    /// </summary>
    int WatchdogTimeoutMs { get; set; }

    /// <summary>
    /// Gets or sets the communication port number.
    /// </summary>
    int Port { get; set; }

    /// <summary>
    /// Gets or sets the auto tag generation port.
    /// Only applicable for GS device models.
    /// </summary>
    int AutoTagGenerationPort { get; set; }
}