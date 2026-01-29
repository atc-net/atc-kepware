namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.HoneywellHc900Ethernet;

/// <summary>
/// Device request properties for the Honeywell HC900 Ethernet driver.
/// </summary>
internal sealed class HoneywellHc900EthernetDeviceRequest : DeviceRequestBase, IHoneywellHc900EthernetDeviceRequest
{
    public HoneywellHc900EthernetDeviceRequest()
        : base(DriverType.HoneywellHc900Ethernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public HoneywellHc900EthernetDeviceModelType Model { get; set; } = HoneywellHc900EthernetDeviceModelType.Hc900;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_ID_FORMAT")]
    public HoneywellHc900EthernetDeviceIdFormatType IdFormat { get; set; } = HoneywellHc900EthernetDeviceIdFormatType.Octal;

    /// <inheritdoc />
    [Required]
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

    /// <inheritdoc />
    [Range(1, 30)]
    [JsonPropertyName("servermain.DEVICE_CONNECTION_TIMEOUT_SECONDS")]
    public int ConnectTimeoutSeconds { get; set; } = 3;

    /// <inheritdoc />
    [Range(50, 9999999)]
    [JsonPropertyName("servermain.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeoutMs { get; set; } = 1000;

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
    public int TimeoutsToDemote { get; set; } = 3;

    /// <inheritdoc />
    [Range(100, 3600000)]
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_PERIOD_MS")]
    public int DemotionPeriodMs { get; set; } = 10000;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DISCARD_WRITES")]
    public bool DiscardRequestsWhenDemoted { get; set; }

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_PORT_NUMBER")]
    public int Port { get; set; } = 502;

    /// <inheritdoc />
    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_FIRST_WORD_LOW")]
    public bool FirstWordLow { get; set; }

    /// <inheritdoc />
    [Range(8, 800)]
    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_OUTPUT_COILS")]
    public int OutputCoils { get; set; } = 32;

    /// <inheritdoc />
    [Range(8, 800)]
    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_INPUT_COILS")]
    public int InputCoils { get; set; } = 32;

    /// <inheritdoc />
    [Range(1, 120)]
    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_INTERNAL_REGISTERS")]
    public int InternalRegisters { get; set; } = 32;

    /// <inheritdoc />
    [Range(1, 120)]
    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_HOLDING_REGISTERS")]
    public int HoldingRegisters { get; set; } = 32;

    /// <inheritdoc />
    [Range(0, 32)]
    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_NUMBER_OF_LOOPS")]
    public int NumberOfLoops { get; set; }

    /// <inheritdoc />
    [Range(0, 600)]
    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_NUMBER_OF_VARIABLES")]
    public int NumberOfVariables { get; set; }

    /// <inheritdoc />
    [Range(0, 4000)]
    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_NUMBER_OF_SIGNAL_TAGS")]
    public int NumberOfSignalTags { get; set; }

    /// <inheritdoc />
    [Range(0, 8)]
    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_NUMBER_OF_SP_PROGRAMMERS")]
    public int NumberOfSpProgrammers { get; set; }

    /// <inheritdoc />
    [Range(0, 50)]
    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_SEGMENTS1")]
    public int Segments1 { get; set; }

    /// <inheritdoc />
    [Range(0, 50)]
    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_SEGMENTS2")]
    public int Segments2 { get; set; }

    /// <inheritdoc />
    [Range(0, 50)]
    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_SEGMENTS3")]
    public int Segments3 { get; set; }

    /// <inheritdoc />
    [Range(0, 50)]
    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_SEGMENTS4")]
    public int Segments4 { get; set; }

    /// <inheritdoc />
    [Range(0, 50)]
    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_SEGMENTS5")]
    public int Segments5 { get; set; }

    /// <inheritdoc />
    [Range(0, 50)]
    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_SEGMENTS6")]
    public int Segments6 { get; set; }

    /// <inheritdoc />
    [Range(0, 50)]
    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_SEGMENTS7")]
    public int Segments7 { get; set; }

    /// <inheritdoc />
    [Range(0, 50)]
    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_SEGMENTS8")]
    public int Segments8 { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_TAG_IMPORT_FILES")]
    public string? TagImportFiles { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_DISPLAY_DESCRIPTIONS")]
    public bool DisplayDescriptions { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("honeywell_hc900_ethernet.DEVICE_TAG_NAMING")]
    public HoneywellHc900EthernetDeviceTagNamingType TagNaming { get; set; } = HoneywellHc900EthernetDeviceTagNamingType.Enhanced;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ON_PROPERTY_CHANGE")]
    public bool TagGenerationOnPropertyChange { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ON_STARTUP")]
    public DeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; } = DeviceTagGenerationOnStartupType.GenerateOnFirstStartup;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_DUPLICATE_HANDLING")]
    public DeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; } = DeviceTagGenerationDuplicateHandlingType.DeleteOnCreate;

    /// <inheritdoc />
    [MaxLength(256)]
    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_GROUP")]
    public string? TagGenerationGroup { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ALLOW_SUB_GROUPS")]
    public bool AllowAutomaticallyGeneratedSubgroups { get; set; } = true;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IdFormat)}: {IdFormat}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}