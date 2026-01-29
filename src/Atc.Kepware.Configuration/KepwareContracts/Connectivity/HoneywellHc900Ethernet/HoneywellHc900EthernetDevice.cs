namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.HoneywellHc900Ethernet;

/// <summary>
/// Device properties for the Honeywell HC900 Ethernet driver.
/// </summary>
internal sealed class HoneywellHc900EthernetDevice : DeviceBase, IHoneywellHc900EthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public HoneywellHc900EthernetDeviceModelType Model { get; set; }

    [JsonPropertyName("servermain.DEVICE_ID_FORMAT")]
    public HoneywellHc900EthernetDeviceIdFormatType IdFormat { get; set; }

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

    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_PORT_NUMBER")]
    public int Port { get; set; }

    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_FIRST_WORD_LOW")]
    public bool FirstWordLow { get; set; }

    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_OUTPUT_COILS")]
    public int OutputCoils { get; set; }

    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_INPUT_COILS")]
    public int InputCoils { get; set; }

    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_INTERNAL_REGISTERS")]
    public int InternalRegisters { get; set; }

    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_HOLDING_REGISTERS")]
    public int HoldingRegisters { get; set; }

    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_NUMBER_OF_LOOPS")]
    public int NumberOfLoops { get; set; }

    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_NUMBER_OF_VARIABLES")]
    public int NumberOfVariables { get; set; }

    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_NUMBER_OF_SIGNAL_TAGS")]
    public int NumberOfSignalTags { get; set; }

    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_NUMBER_OF_SP_PROGRAMMERS")]
    public int NumberOfSpProgrammers { get; set; }

    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_SEGMENTS1")]
    public int Segments1 { get; set; }

    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_SEGMENTS2")]
    public int Segments2 { get; set; }

    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_SEGMENTS3")]
    public int Segments3 { get; set; }

    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_SEGMENTS4")]
    public int Segments4 { get; set; }

    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_SEGMENTS5")]
    public int Segments5 { get; set; }

    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_SEGMENTS6")]
    public int Segments6 { get; set; }

    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_SEGMENTS7")]
    public int Segments7 { get; set; }

    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_SEGMENTS8")]
    public int Segments8 { get; set; }

    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_TAG_IMPORT_FILES")]
    public string? TagImportFiles { get; set; }

    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_DISPLAY_DESCRIPTIONS")]
    public bool DisplayDescriptions { get; set; }

    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_TAG_NAMING")]
    public HoneywellHc900EthernetDeviceTagNamingType TagNaming { get; set; }

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ON_PROPERTY_CHANGE")]
    public bool TagGenerationOnPropertyChange { get; set; }

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ON_STARTUP")]
    public DeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; }

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_DUPLICATE_HANDLING")]
    public DeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; }

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_GROUP")]
    public string? TagGenerationGroup { get; set; }

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ALLOW_SUB_GROUPS")]
    public bool AllowAutomaticallyGeneratedSubgroups { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IdFormat)}: {IdFormat}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}
