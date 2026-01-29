namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.AllenBradleyBulletin900;

/// <summary>
/// Device request properties for the Allen-Bradley Bulletin 900 driver.
/// </summary>
public interface IAllenBradleyBulletin900DeviceRequest
{
    /// <summary>
    /// Select the specific type of device associated with this ID.
    /// </summary>
    Bulletin900DeviceModelType Model { get; set; }

    /// <summary>
    /// Specify the device's driver-specific station or node.
    /// </summary>
    int DeviceId { get; set; }

    /// <summary>
    /// Specify the four-field IP address of the terminal server for this device.
    /// </summary>
    string? IpAddress { get; set; }

    /// <summary>
    /// The port number the device uses to communicate.
    /// </summary>
    int EthernetPort { get; set; }

    /// <summary>
    /// Select TCP/IP or UDP communications for the terminal server in use.
    /// </summary>
    Bulletin900EthernetProtocolType EthernetProtocol { get; set; }

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
    /// Specify if the driver should use the Process Value Scaling Factor for all applicable tags.
    /// </summary>
    bool ProcessValueScaling { get; set; }

    /// <summary>
    /// Specify the scaling factor.
    /// </summary>
    float ProcessValueScalingFactor { get; set; }

    /// <summary>
    /// Specify the type of input (for Enhanced models only).
    /// </summary>
    Bulletin900InputType InputType { get; set; }
}
