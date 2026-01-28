namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.BeckhoffTwinCat;

/// <summary>
/// Device properties for the Beckhoff TwinCAT driver.
/// </summary>
internal sealed class BeckhoffTwinCatDevice : DeviceBase, IBeckhoffTwinCatDevice
{
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public BeckhoffTwinCatModel Model { get; set; }

    [JsonPropertyName("servermain.DEVICE_ID_FORMAT")]
    public BeckhoffTwinCatIdFormat IdFormat { get; set; }

    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

    [JsonPropertyName("servermain.DEVICE_CONNECTION_TIMEOUT_SECONDS")]
    public int ConnectTimeoutSeconds { get; set; }

    [JsonPropertyName("servermain.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeoutMs { get; set; }

    [JsonPropertyName("servermain.DEVICE_RETRY_ATTEMPTS")]
    public int RetryAttempts { get; set; }

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

    [JsonPropertyName("beckhoff_twincat.DEVICE_PORT_NUMBER")]
    public int PortNumber { get; set; }

    [JsonPropertyName("beckhoff_twincat.DEVICE_DEFAULT_TYPE")]
    public BeckhoffTwinCatDefaultType DefaultType { get; set; }

    [JsonPropertyName("beckhoff_twincat.DEVICE_IMPORT_SOURCE")]
    public BeckhoffTwinCatImportSource ImportSource { get; set; }

    [JsonPropertyName("beckhoff_twincat.DEVICE_SYMBOL_FILE")]
    public string? SymbolFile { get; set; }

    [JsonPropertyName("beckhoff_twincat.DEVICE_AUTO_SYNCHRONIZE_WITH_SYMBOL_FILE_CHANGES")]
    public bool AutoSynchronizeFileChanges { get; set; }

    [JsonPropertyName("beckhoff_twincat.DEVICE_RESPECT_OPC_READ_WRITE_ITEM_PROPERTIES")]
    public bool RespectOpcReadWriteItemProperties { get; set; }

    [JsonPropertyName("beckhoff_twincat.DEVICE_RESPECT_TAG_CASE_ON_IMPORT")]
    public bool RespectTagCaseOnImport { get; set; }

    [JsonPropertyName("beckhoff_twincat.DEVICE_ONLY_IMPORT_VARIABLE_MARKED_FOR_OPC")]
    public bool OnlyImportVariablesMarkedForOpc { get; set; }

    [JsonPropertyName("beckhoff_twincat.DEVICE_ADDITIONAL_OPC_FILTER")]
    public string? AdditionalFilter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IdFormat)}: {IdFormat}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}, {nameof(DefaultType)}: {DefaultType}";
}
