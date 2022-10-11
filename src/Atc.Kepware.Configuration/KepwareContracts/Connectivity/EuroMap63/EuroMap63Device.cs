namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.EuroMap63;

internal class EuroMap63Device : DeviceBase, IEuroMap63Device
{
    [JsonPropertyName("servermain.DEVICE_CONNECTION_TIMEOUT_SECONDS")]
    public int ConnectionTimeout { get; set; }

    [JsonPropertyName("servermain.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeout { get; set; }

    [JsonPropertyName("servermain.DEVICE_RETRY_ATTEMPTS")]
    public int RetryAttempts { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_ENABLE_ON_COMMUNICATIONS_FAILURES")]
    public bool DemoteOnFailure { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DEMOTE_AFTER_SUCCESSIVE_TIMEOUTS")]
    public int TimeoutToDemote { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_PERIOD_MS")]
    public int DemotionPeriod { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DISCARD_WRITES")]
    public bool DiscardWriteRequestsWhenDemoted { get; set; }

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ON_STARTUP")]
    public EuroMap63DeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; }

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_DUPLICATE_HANDLING")]
    public EuroMap63DeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; }

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_GROUP")]
    public string? TagGenerationGroup { get; set; }

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ALLOW_SUB_GROUPS")]
    public bool AllowAutomaticallyGeneratedSubgroups { get; set; }

    [JsonPropertyName("euromap_63.DEVICE_TAG_IMPORT_SOURCE")]
    public EuroMap63DeviceTagImportSourceType DeviceTagImportSource { get; set; }

    [JsonPropertyName("euromap_63.DEVICE_TAG_IMPORT_FILE")]
    public string TagImportFile { get; set; } = string.Empty;

    [JsonPropertyName("euromap_63.DEVICE_SESSION_FILE_PATH")]
    public string SessionFilePath { get; set; } = string.Empty;

    [JsonPropertyName("euromap_63.DEVICE_MIN_SESSION_NUMBER")]
    public int MinimumSessionNumber { get; set; }

    [JsonPropertyName("euromap_63.DEVICE_MAX_SESSION_NUMBER")]
    public int MaximumSessionNumber { get; set; }

    [JsonPropertyName("euromap_63.DEVICE_PREVALIDATE_TAGS")]
    public bool PreValidateTags { get; set; }

    [JsonPropertyName("euromap_63.DEVICE_MAX_FILE_SIZE")]
    public int MaxFileSize { get; set; }

    [JsonPropertyName("euromap_63.DEVICE_CHARACTER_ENCODING")]
    public EuroMap63CharacterEncodingType CharacterEncoding { get; set; }

    [JsonPropertyName("euromap_63.DEVICE_INCLUDE_CYCLIC")]
    public bool IncludeCyclic { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(ConnectionTimeout)}: {ConnectionTimeout}, {nameof(RequestTimeout)}: {RequestTimeout}, {nameof(RetryAttempts)}: {RetryAttempts}, {nameof(DemoteOnFailure)}: {DemoteOnFailure}, {nameof(TimeoutToDemote)}: {TimeoutToDemote}, {nameof(DemotionPeriod)}: {DemotionPeriod}, {nameof(DiscardWriteRequestsWhenDemoted)}: {DiscardWriteRequestsWhenDemoted}, {nameof(TagGenerationOnStartup)}: {TagGenerationOnStartup}, {nameof(TagGenerationDuplicateHandling)}: {TagGenerationDuplicateHandling}, {nameof(TagGenerationGroup)}: {TagGenerationGroup}, {nameof(AllowAutomaticallyGeneratedSubgroups)}: {AllowAutomaticallyGeneratedSubgroups}, {nameof(DeviceTagImportSource)}: {DeviceTagImportSource}, {nameof(TagImportFile)}: {TagImportFile}, {nameof(SessionFilePath)}: {SessionFilePath}, {nameof(MinimumSessionNumber)}: {MinimumSessionNumber}, {nameof(MaximumSessionNumber)}: {MaximumSessionNumber}, {nameof(PreValidateTags)}: {PreValidateTags}, {nameof(MaxFileSize)}: {MaxFileSize}, {nameof(CharacterEncoding)}: {CharacterEncoding}, {nameof(IncludeCyclic)}: {IncludeCyclic}";
}