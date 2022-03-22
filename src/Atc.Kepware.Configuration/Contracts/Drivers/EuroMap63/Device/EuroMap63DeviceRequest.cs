namespace Atc.Kepware.Configuration.Contracts.Drivers.EuroMap63.Device;

public class EuroMap63DeviceRequest : DeviceRequestBase
{
    public EuroMap63DeviceRequest()
        : base(DriverType.EuroMap63)
    {
    }

    /// <summary>
    /// Defines the maximum amount of time, in seconds, allowed to establish a connection to a remote device.
    /// Connection time is often longer than communication request time for a device.
    /// </summary>
    [Range(1, 30)]
    [JsonPropertyName("servermain.DEVICE_CONNECTION_TIMEOUT_SECONDS")]
    public int ConnectionTimeout { get; set; } = 30;

    /// <summary>
    /// Specifies an interval, in milliseconds, to determine how long the driver waits for a response
    /// from the target device to indicate completion.
    /// </summary>
    [Range(1000, 9000000)]
    [JsonPropertyName("servermain.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeout { get; set; } = 120000;

    /// <summary>
    /// Indicates how many times the driver sends a communications request
    /// before considering the request to have failed and the device to be in error.
    /// </summary>
    [Range(1, 10)]
    [JsonPropertyName("servermain.DEVICE_RETRY_ATTEMPTS")]
    public int RetryAttempts { get; set; } = 3;

    /// <summary>
    /// If set to true, automatically removes the device from the scan due to communication failures.
    /// </summary>
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_ENABLE_ON_COMMUNICATIONS_FAILURES")]
    public bool DemoteOnFailure { get; set; }

    /// <summary>
    /// Specifies how many successive cycles of request timeouts and retries occur
    /// before the device is placed off-scan.
    /// </summary>
    /// <remarks>
    /// Property is only applicable when <see cref="DemoteOnFailure"/> is true.
    /// </remarks>
    [Range(1, 30)]
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DEMOTE_AFTER_SUCCESSIVE_TIMEOUTS")]
    public int TimeoutToDemote { get; set; } = 3;

    /// <summary>
    /// Indicates how long, in milliseconds, before scanning is attempted again on a demoted device.
    /// </summary>
    /// <remarks>
    /// Property is only applicable when <see cref="DemoteOnFailure"/> is true.
    /// </remarks>
    [Range(100, 3600000)]
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_PERIOD_MS")]
    public int DemotionPeriod { get; set; } = 10000;

    /// <summary>
    /// Select whether or not write requests are attempted during the off-scan period.
    /// The default setting always sends write requests regardless of the demotion period.
    /// Enabling discards write requests and the server automatically fails requests
    /// received from a client without a failure message in the Event Log.
    /// </summary>
    /// <remarks>
    /// Property is only applicable when <see cref="DemoteOnFailure"/> is true.
    /// </remarks>
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DISCARD_WRITES")]
    public bool DiscardWriteRequestsWhenDemoted { get; set; }

    /// <summary>
    /// Determines the automatic tag generation action to be taken on device startup.
    /// </summary>
    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ON_STARTUP")]
    public EuroMap63DeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; } = EuroMap63DeviceTagGenerationOnStartupType.AlwaysGenerateOnStartup;

    /// <summary>
    /// Indicates the preferred method of avoiding creation of duplicate tags.
    /// </summary>
    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_DUPLICATE_HANDLING")]
    public EuroMap63DeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; } = EuroMap63DeviceTagGenerationDuplicateHandlingType.DeleteOnCreate;

    /// <summary>
    /// Indicates a tag group name for new generated tags.
    /// If empty, generated tags are added at the device level.
    /// </summary>
    [MaxLength(256)]
    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_GROUP")]
    public string? TagGenerationGroup { get; set; }

    /// <summary>
    /// Instructs the server to automatically create sub groups for automatically generated tags.
    /// </summary>
    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ALLOW_SUB_GROUPS")]
    public bool AllowAutomaticallyGeneratedSubgroups { get; set; } = true;

    /// <summary>
    /// The source from which tags will be imported.
    /// </summary>
    [JsonPropertyName("euromap_63.DEVICE_TAG_IMPORT_SOURCE")]
    public EuroMap63DeviceTagImportSourceType DeviceTagImportSource { get; set; } = EuroMap63DeviceTagImportSourceType.Device;

    /// <summary>
    /// The path and file name of the EUROMAP 63 GETID response file from which to generate tags.
    /// </summary>
    /// <remarks>
    /// Property is only applicable when <see cref="EuroMap63DeviceTagImportSourceType"/> is set to <see cref="EuroMap63DeviceTagImportSourceType.File"/>.
    /// </remarks>
    [JsonPropertyName("euromap_63.DEVICE_TAG_IMPORT_FILE")]
    public string TagImportFile { get; set; } = "*.dat";

    /// <summary>
    /// The path to the session file directory.
    /// </summary>
    [JsonPropertyName("euromap_63.DEVICE_SESSION_FILE_PATH")]
    public string SessionFilePath { get; set; } = string.Empty;

    /// <summary>
    /// The minimum session number used for session requests.
    /// </summary>
    [Range(0, 9999)]
    [JsonPropertyName("euromap_63.DEVICE_MIN_SESSION_NUMBER")]
    public int MinimumSessionNumber { get; set; }

    /// <summary>
    /// The maximum session number used for session requests.
    /// </summary>
    [Range(0, 9999)]
    [JsonPropertyName("euromap_63.DEVICE_MAX_SESSION_NUMBER")]
    public int MaximumSessionNumber { get; set; } = 10;

    /// <summary>
    /// Instruct the driver to obtain the list of supported parameters on first communication with the device when true.
    /// </summary>
    [JsonPropertyName("euromap_63.DEVICE_PREVALIDATE_TAGS")]
    public bool PreValidateTags { get; set; } = true;

    /// <summary>
    /// The maximum file size, in kilobytes, allowed for any EUROMAP 63 file.
    /// </summary>
    [Range(50, 65535)]
    [JsonPropertyName("euromap_63.DEVICE_MAX_FILE_SIZE")]
    public int MaxFileSize { get; set; } = 20000;

    /// <summary>
    /// The character encoding corresponding to the character definition code page defined by the device.
    /// </summary>
    [JsonPropertyName("euromap_63.DEVICE_CHARACTER_ENCODING")]
    public EuroMap63CharacterEncodingType CharacterEncoding { get; set; } = EuroMap63CharacterEncodingType.Utf8;

    /// <summary>
    /// When enabled the CYCLIC keyword is included in the REPORT command.
    /// </summary>
    [JsonPropertyName("euromap_63.DEVICE_INCLUDE_CYCLIC")]
    public bool IncludeCyclic { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(ConnectionTimeout)}: {ConnectionTimeout}, {nameof(RequestTimeout)}: {RequestTimeout}, {nameof(RetryAttempts)}: {RetryAttempts}, {nameof(DemoteOnFailure)}: {DemoteOnFailure}, {nameof(TimeoutToDemote)}: {TimeoutToDemote}, {nameof(DemotionPeriod)}: {DemotionPeriod}, {nameof(DiscardWriteRequestsWhenDemoted)}: {DiscardWriteRequestsWhenDemoted}, {nameof(TagGenerationOnStartup)}: {TagGenerationOnStartup}, {nameof(TagGenerationDuplicateHandling)}: {TagGenerationDuplicateHandling}, {nameof(TagGenerationGroup)}: {TagGenerationGroup}, {nameof(AllowAutomaticallyGeneratedSubgroups)}: {AllowAutomaticallyGeneratedSubgroups}, {nameof(DeviceTagImportSource)}: {DeviceTagImportSource}, {nameof(TagImportFile)}: {TagImportFile}, {nameof(SessionFilePath)}: {SessionFilePath}, {nameof(MinimumSessionNumber)}: {MinimumSessionNumber}, {nameof(MaximumSessionNumber)}: {MaximumSessionNumber}, {nameof(PreValidateTags)}: {PreValidateTags}, {nameof(MaxFileSize)}: {MaxFileSize}, {nameof(CharacterEncoding)}: {CharacterEncoding}, {nameof(IncludeCyclic)}: {IncludeCyclic}";
}