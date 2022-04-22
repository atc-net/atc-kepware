namespace Atc.Kepware.Configuration.Contracts.Interfaces.EuroMap63;

public interface IEuroMap63DeviceRequest
{
    /// <summary>
    /// Defines the maximum amount of time, in seconds, allowed to establish a connection to a remote device.
    /// Connection time is often longer than communication request time for a device.
    /// </summary>
    int ConnectionTimeout { get; set; }

    /// <summary>
    /// Specifies an interval, in milliseconds, to determine how long the driver waits for a response
    /// from the target device to indicate completion.
    /// </summary>
    int RequestTimeout { get; set; }

    /// <summary>
    /// Indicates how many times the driver sends a communications request
    /// before considering the request to have failed and the device to be in error.
    /// </summary>
    int RetryAttempts { get; set; }

    /// <summary>
    /// If set to true, automatically removes the device from the scan due to communication failures.
    /// </summary>
    bool DemoteOnFailure { get; set; }

    /// <summary>
    /// Specifies how many successive cycles of request timeouts and retries occur
    /// before the device is placed off-scan.
    /// </summary>
    /// <remarks>
    /// Property is only applicable when <see cref="DemoteOnFailure"/> is true.
    /// </remarks>
    int TimeoutToDemote { get; set; }

    /// <summary>
    /// Indicates how long, in milliseconds, before scanning is attempted again on a demoted device.
    /// </summary>
    /// <remarks>
    /// Property is only applicable when <see cref="DemoteOnFailure"/> is true.
    /// </remarks>
    int DemotionPeriod { get; set; }

    /// <summary>
    /// Select whether or not write requests are attempted during the off-scan period.
    /// The default setting always sends write requests regardless of the demotion period.
    /// Enabling discards write requests and the server automatically fails requests
    /// received from a client without a failure message in the Event Log.
    /// </summary>
    /// <remarks>
    /// Property is only applicable when <see cref="DemoteOnFailure"/> is true.
    /// </remarks>
    bool DiscardWriteRequestsWhenDemoted { get; set; }

    /// <summary>
    /// Determines the automatic tag generation action to be taken on device startup.
    /// </summary>
    EuroMap63DeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; }

    /// <summary>
    /// Indicates the preferred method of avoiding creation of duplicate tags.
    /// </summary>
    EuroMap63DeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; }

    /// <summary>
    /// Indicates a tag group name for new generated tags.
    /// If empty, generated tags are added at the device level.
    /// </summary>
    string? TagGenerationGroup { get; set; }

    /// <summary>
    /// Instructs the server to automatically create sub groups for automatically generated tags.
    /// </summary>
    bool AllowAutomaticallyGeneratedSubgroups { get; set; }

    /// <summary>
    /// The source from which tags will be imported.
    /// </summary>
    EuroMap63DeviceTagImportSourceType DeviceTagImportSource { get; set; }

    /// <summary>
    /// The path and file name of the EUROMAP 63 GETID response file from which to generate tags.
    /// </summary>
    /// <remarks>
    /// Property is only applicable when <see cref="EuroMap63DeviceTagImportSourceType"/> is set to <see cref="EuroMap63DeviceTagImportSourceType.File"/>.
    /// </remarks>
    string TagImportFile { get; set; }

    /// <summary>
    /// The path to the session file directory.
    /// </summary>
    string SessionFilePath { get; set; }

    /// <summary>
    /// The minimum session number used for session requests.
    /// </summary>
    int MinimumSessionNumber { get; set; }

    /// <summary>
    /// The maximum session number used for session requests.
    /// </summary>
    int MaximumSessionNumber { get; set; }

    /// <summary>
    /// Instruct the driver to obtain the list of supported parameters on first communication with the device when true.
    /// </summary>
    bool PreValidateTags { get; set; }

    /// <summary>
    /// The maximum file size, in kilobytes, allowed for any EUROMAP 63 file.
    /// </summary>
    int MaxFileSize { get; set; }

    /// <summary>
    /// The character encoding corresponding to the character definition code page defined by the device.
    /// </summary>
    EuroMap63CharacterEncodingType CharacterEncoding { get; set; }

    /// <summary>
    /// When enabled the CYCLIC keyword is included in the REPORT command.
    /// </summary>
    bool IncludeCyclic { get; set; }
}