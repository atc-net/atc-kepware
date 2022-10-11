namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.EuroMap63;

internal class EuroMap63DeviceRequest : DeviceRequestBase, IEuroMap63DeviceRequest
{
    public EuroMap63DeviceRequest()
        : base(DriverType.EuroMap63)
    {
    }

    /// <inheritdoc />
    [Range(1, 30)]
    [JsonPropertyName("servermain.DEVICE_CONNECTION_TIMEOUT_SECONDS")]
    public int ConnectionTimeout { get; set; } = 30;

    /// <inheritdoc />
    [Range(1000, 9000000)]
    [JsonPropertyName("servermain.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeout { get; set; } = 120000;

    /// <inheritdoc />
    [Range(1, 10)]
    [JsonPropertyName("servermain.DEVICE_RETRY_ATTEMPTS")]
    public int RetryAttempts { get; set; } = 3;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_ENABLE_ON_COMMUNICATIONS_FAILURES")]
    public bool DemoteOnFailure { get; set; }

    /// <inheritdoc />
    [Range(1, 30)]
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DEMOTE_AFTER_SUCCESSIVE_TIMEOUTS")]
    public int TimeoutToDemote { get; set; } = 3;

    /// <inheritdoc />
    [Range(100, 3600000)]
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_PERIOD_MS")]
    public int DemotionPeriod { get; set; } = 10000;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DISCARD_WRITES")]
    public bool DiscardWriteRequestsWhenDemoted { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ON_STARTUP")]
    public EuroMap63DeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; } = EuroMap63DeviceTagGenerationOnStartupType.AlwaysGenerateOnStartup;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_DUPLICATE_HANDLING")]
    public EuroMap63DeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; } = EuroMap63DeviceTagGenerationDuplicateHandlingType.DeleteOnCreate;

    /// <inheritdoc />
    [MaxLength(256)]
    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_GROUP")]
    public string? TagGenerationGroup { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ALLOW_SUB_GROUPS")]
    public bool AllowAutomaticallyGeneratedSubgroups { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("euromap_63.DEVICE_TAG_IMPORT_SOURCE")]
    public EuroMap63DeviceTagImportSourceType DeviceTagImportSource { get; set; } = EuroMap63DeviceTagImportSourceType.Device;

    /// <inheritdoc />
    [JsonPropertyName("euromap_63.DEVICE_TAG_IMPORT_FILE")]
    public string TagImportFile { get; set; } = "*.dat";

    /// <inheritdoc />
    [JsonPropertyName("euromap_63.DEVICE_SESSION_FILE_PATH")]
    public string SessionFilePath { get; set; } = string.Empty;

    /// <inheritdoc />
    [Range(0, 9999)]
    [JsonPropertyName("euromap_63.DEVICE_MIN_SESSION_NUMBER")]
    public int MinimumSessionNumber { get; set; }

    /// <inheritdoc />
    [Range(0, 9999)]
    [JsonPropertyName("euromap_63.DEVICE_MAX_SESSION_NUMBER")]
    public int MaximumSessionNumber { get; set; } = 10;

    /// <inheritdoc />
    [JsonPropertyName("euromap_63.DEVICE_PREVALIDATE_TAGS")]
    public bool PreValidateTags { get; set; } = true;

    /// <inheritdoc />
    [Range(50, 65535)]
    [JsonPropertyName("euromap_63.DEVICE_MAX_FILE_SIZE")]
    public int MaxFileSize { get; set; } = 20000;

    /// <inheritdoc />
    [JsonPropertyName("euromap_63.DEVICE_CHARACTER_ENCODING")]
    public EuroMap63CharacterEncodingType CharacterEncoding { get; set; } = EuroMap63CharacterEncodingType.Utf8;

    /// <inheritdoc />
    [JsonPropertyName("euromap_63.DEVICE_INCLUDE_CYCLIC")]
    public bool IncludeCyclic { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(ConnectionTimeout)}: {ConnectionTimeout}, {nameof(RequestTimeout)}: {RequestTimeout}, {nameof(RetryAttempts)}: {RetryAttempts}, {nameof(DemoteOnFailure)}: {DemoteOnFailure}, {nameof(TimeoutToDemote)}: {TimeoutToDemote}, {nameof(DemotionPeriod)}: {DemotionPeriod}, {nameof(DiscardWriteRequestsWhenDemoted)}: {DiscardWriteRequestsWhenDemoted}, {nameof(TagGenerationOnStartup)}: {TagGenerationOnStartup}, {nameof(TagGenerationDuplicateHandling)}: {TagGenerationDuplicateHandling}, {nameof(TagGenerationGroup)}: {TagGenerationGroup}, {nameof(AllowAutomaticallyGeneratedSubgroups)}: {AllowAutomaticallyGeneratedSubgroups}, {nameof(DeviceTagImportSource)}: {DeviceTagImportSource}, {nameof(TagImportFile)}: {TagImportFile}, {nameof(SessionFilePath)}: {SessionFilePath}, {nameof(MinimumSessionNumber)}: {MinimumSessionNumber}, {nameof(MaximumSessionNumber)}: {MaximumSessionNumber}, {nameof(PreValidateTags)}: {PreValidateTags}, {nameof(MaxFileSize)}: {MaxFileSize}, {nameof(CharacterEncoding)}: {CharacterEncoding}, {nameof(IncludeCyclic)}: {IncludeCyclic}";
}