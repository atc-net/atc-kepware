namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.HoneywellUdcEthernet;

/// <summary>
/// Interface for Honeywell UDC Ethernet device properties.
/// </summary>
public interface IHoneywellUdcEthernetDevice : IDeviceBase
{
    /// <summary>
    /// Select the specific type of device associated with this ID.
    /// </summary>
    HoneywellUdcEthernetDeviceModelType Model { get; set; }

    /// <summary>
    /// Indicate the format of the device ID.
    /// </summary>
    HoneywellUdcEthernetDeviceIdFormatType IdFormat { get; set; }

    /// <summary>
    /// Specify the device's driver-specific station or node.
    /// Format: IP Address (e.g., "192.168.1.1")
    /// </summary>
    string DeviceId { get; set; }

    /// <summary>
    /// Define the maximum amount of time, in seconds, allowed to establish a connection to a remote device.
    /// </summary>
    int ConnectTimeoutSeconds { get; set; }

    /// <summary>
    /// Specify an interval, in milliseconds, to determine how long the driver waits for a response.
    /// </summary>
    int RequestTimeoutMs { get; set; }

    /// <summary>
    /// Indicate how many times the driver sends a communications request before considering it failed.
    /// </summary>
    int RetryAttempts { get; set; }

    /// <summary>
    /// Define how long, in milliseconds, the driver waits before sending the next request.
    /// </summary>
    int InterRequestDelayMs { get; set; }

    /// <summary>
    /// Automatically remove the device from the scan due to communication failures.
    /// </summary>
    bool DemoteOnFailure { get; set; }

    /// <summary>
    /// Specify how many successive cycles of request timeouts occur before the device is placed off-scan.
    /// </summary>
    int TimeoutsToDemote { get; set; }

    /// <summary>
    /// Indicate how long, in milliseconds, before scanning is attempted again on a demoted device.
    /// </summary>
    int DemotionPeriodMs { get; set; }

    /// <summary>
    /// Select whether write requests are discarded during the off-scan period.
    /// </summary>
    bool DiscardRequestsWhenDemoted { get; set; }

    /// <summary>
    /// Select the automatic tag generation action to be taken on device startup.
    /// </summary>
    DeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; }

    /// <summary>
    /// Indicate the preferred method of avoiding creation of duplicate tags.
    /// </summary>
    DeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; }

    /// <summary>
    /// Indicate a tag group name for new generated tags.
    /// </summary>
    string? TagGenerationGroup { get; set; }

    /// <summary>
    /// Instruct the server to automatically create sub groups for automatically generated tags.
    /// </summary>
    bool AllowAutomaticallyGeneratedSubgroups { get; set; }

    /// <summary>
    /// The TCP/IP port number that the remote device is configured to use.
    /// </summary>
    int Port { get; set; }

    /// <summary>
    /// Set to true if the driver should assume the first word is the low word of a 32-bit value.
    /// </summary>
    bool FirstWordLow { get; set; }

    /// <summary>
    /// Specify the number of internal registers that should be read from the device in a single request.
    /// </summary>
    int InternalRegisters { get; set; }

    /// <summary>
    /// Specify the number of holding registers that should be read from the device in a single request.
    /// </summary>
    int HoldingRegisters { get; set; }
}
