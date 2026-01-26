namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AllenBradleyControlLogixEthernet;

/// <summary>
/// Device properties for the Allen-Bradley ControlLogix Ethernet driver.
/// </summary>
internal sealed class AllenBradleyControlLogixEthernetDevice : DeviceBase, IAllenBradleyControlLogixEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public ControlLogixDeviceModelType Model { get; set; }

    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

    [JsonPropertyName("servermain.DEVICE_CONNECTION_TIMEOUT_SECONDS")]
    public int ConnectTimeoutSeconds { get; set; }

    [JsonPropertyName("servermain.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeoutMs { get; set; }

    [JsonPropertyName("servermain.DEVICE_RETRY_ATTEMPTS")]
    public int RetryAttempts { get; set; }

    [JsonPropertyName("servermain.DEVICE_INTER_REQUEST_DELAY_MILLISECONDS")]
    public int InterRequestDelayMs { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_ENABLE_ON_COMMUNICATIONS_FAILURES")]
    public bool DemoteOnFailure { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DEMOTE_AFTER_SUCCESSIVE_TIMEOUTS")]
    public int TimeoutsToDemote { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_PERIOD_MS")]
    public int DemotionPeriodMs { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DISCARD_WRITES")]
    public bool DiscardRequestsWhenDemoted { get; set; }

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ON_STARTUP")]
    public DeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; }

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_DUPLICATE_HANDLING")]
    public DeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; }

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_GROUP")]
    public string? TagGenerationGroup { get; set; }

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ALLOW_SUB_GROUPS")]
    public bool AllowAutomaticallyGeneratedSubgroups { get; set; }

    [JsonPropertyName("controllogix_ethernet.DEVICE_PORT_NUMBER")]
    public int Port { get; set; }

    [JsonPropertyName("controllogix_ethernet.DEVICE_CONNECTION_SIZE_BYTES")]
    public int ConnectionSizeBytes { get; set; }

    [JsonPropertyName("controllogix_ethernet.DEVICE_INACTIVITY_WATCHDOG_SECONDS")]
    public ControlLogixInactivityWatchdogType InactivityWatchdog { get; set; }

    [JsonPropertyName("controllogix_ethernet.DEVICE_ARRAY_BLOCK_SIZE_ELEMENTS")]
    public ControlLogixArrayBlockSizeType ArrayBlockSize { get; set; }

    [JsonPropertyName("controllogix_ethernet.DEVICE_PROTOCOL_MODE")]
    public ControlLogixProtocolModeType ProtocolMode { get; set; }

    [JsonPropertyName("controllogix_ethernet.DEVICE_ONLINE_EDITS")]
    public bool SynchronizeAfterOnlineEdits { get; set; }

    [JsonPropertyName("controllogix_ethernet.DEVICE_OFFLINE_EDITS")]
    public bool SynchronizeAfterOfflineEdits { get; set; }

    [JsonPropertyName("controllogix_ethernet.DEVICE_AUTOMATICALLY_READ_STRING_LENGTH")]
    public bool TerminateStringDataAtLen { get; set; }

    [JsonPropertyName("controllogix_ethernet.DEVICE_DEFAULT_DATA_TYPE")]
    public ControlLogixDefaultDataType DefaultDataType { get; set; }

    [JsonPropertyName("controllogix_ethernet.DEVICE_ENABLE_PERFORMANCE_STATISTICS")]
    public bool PerformanceStatistics { get; set; }

    [JsonPropertyName("controllogix_ethernet.DEVICE_DATABASE_IMPORT_METHOD")]
    public ControlLogixDatabaseImportMethodType DatabaseImportMethod { get; set; }

    [JsonPropertyName("controllogix_ethernet.DEVICE_TAG_IMPORT_FILE")]
    public string? TagImportFile { get; set; }

    [JsonPropertyName("controllogix_ethernet.DEVICE_DISPLAY_DESCRIPTIONS")]
    public bool TagDescriptions { get; set; }

    [JsonPropertyName("controllogix_ethernet.DEVICE_LIMIT_TAG_NAMES")]
    public bool LimitNameLength { get; set; }

    [JsonPropertyName("controllogix_ethernet.DEVICE_TAG_HIERARCHY")]
    public ControlLogixTagHierarchyType TagHierarchy { get; set; }

    [JsonPropertyName("controllogix_ethernet.DEVICE_IMPOSE_ARRAY_ELEMENT_COUNT_LIMIT")]
    public bool ImposeArrayLimit { get; set; }

    [JsonPropertyName("controllogix_ethernet.DEVICE_ARRAY_ELEMENT_COUNT_LIMIT")]
    public int ArrayCountUpperLimit { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}
