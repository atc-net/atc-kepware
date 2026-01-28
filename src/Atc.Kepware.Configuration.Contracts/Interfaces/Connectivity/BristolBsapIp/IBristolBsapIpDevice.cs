namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.BristolBsapIp;

/// <summary>
/// Interface for Bristol BSAP IP device.
/// </summary>
public interface IBristolBsapIpDevice : IDeviceBase
{
    /// <summary>
    /// Select the specific type of device associated with this ID.
    /// </summary>
    BristolBsapIpDeviceModelType Model { get; set; }

    /// <summary>
    /// Specify the Global Address of the RTU. Enter 0 for local devices.
    /// Value is in hexadecimal (0-65535).
    /// </summary>
    int RtuGlobalAddress { get; set; }

    /// <summary>
    /// Specify the IP address of the RTU.
    /// </summary>
    string RtuIpAddress { get; set; }

    /// <summary>
    /// Specify the UDP port of the RTU.
    /// </summary>
    int RtuUdpPort { get; set; }

    /// <summary>
    /// Specify the maximum number of bytes per read or write request.
    /// </summary>
    int MaximumBytesPerRequest { get; set; }

    /// <summary>
    /// Specify the level of the device.
    /// </summary>
    BristolBsapIpDeviceLevelType Level { get; set; }

    /// <summary>
    /// Specify the request timeout in milliseconds.
    /// </summary>
    int RequestTimeoutMs { get; set; }

    /// <summary>
    /// Specify the number of times a request may timeout before failing.
    /// </summary>
    int FailAfterSuccessiveTimeouts { get; set; }

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
    /// Set the location of the tag import file to be used in tag database creation.
    /// </summary>
    string? TagImportFile { get; set; }
}
