namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.Opto22Ethernet;

public interface IOpto22EthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Select the specific type of device associated with this ID.
    /// </summary>
    Opto22EthernetDeviceModelType Model { get; set; }

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
    /// Specify the TCP/IP port this device will be using.
    /// </summary>
    int Port { get; set; }
}
