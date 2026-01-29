namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.KeyenceKvEthernet;

public interface IKeyenceKvEthernetDevice : IDeviceBase
{
    /// <summary>
    /// Gets or sets the device model.
    /// </summary>
    KeyenceKvEthernetDeviceModelType Model { get; set; }

    /// <summary>
    /// Gets or sets the device ID format.
    /// </summary>
    KeyenceKvEthernetDeviceIdFormatType IdFormat { get; set; }

    /// <summary>
    /// Specify the device's IP address.
    /// Format: &lt;IP_Address&gt; (e.g., "192.168.1.1")
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
    /// Indicate the correct protocol to use when communicating with the device.
    /// Default: TcpIp.
    /// </summary>
    KeyenceKvEthernetIpProtocolType IpProtocol { get; set; }

    /// <summary>
    /// Specify the port number to use when communicating with the device.
    /// Default: 8501.
    /// </summary>
    int PortNumber { get; set; }

    /// <summary>
    /// Specify the block size for Word memory registers.
    /// These include Device Types R, B, MR, LR, CR, VB, DM, EM, FM, ZF, W, TM, CM, and VM.
    /// Default: 1000.
    /// </summary>
    int WordMemoryBlockSize { get; set; }

    /// <summary>
    /// Specify the block size for Timer and Counter memory registers.
    /// These include Device Types T, TC, TS, C, CC, CS.
    /// Default: 120.
    /// </summary>
    int TimerCounterMemoryBlockSize { get; set; }
}
