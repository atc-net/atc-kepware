namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AutomationDirectProductivitySeriesEthernet;

/// <summary>
/// Device request properties for the AutomationDirect Productivity Series Ethernet driver.
/// </summary>
internal sealed class AutomationDirectProductivitySeriesEthernetDeviceRequest : DeviceRequestBase, IAutomationDirectProductivitySeriesEthernetDeviceRequest
{
    public AutomationDirectProductivitySeriesEthernetDeviceRequest()
        : base(DriverType.AutomationDirectProductivitySeriesEthernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public AutomationDirectProductivitySeriesEthernetDeviceModelType Model { get; set; } = AutomationDirectProductivitySeriesEthernetDeviceModelType.P3550;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_ID_FORMAT")]
    public ModbusDeviceIdFormatType IdFormat { get; set; } = ModbusDeviceIdFormatType.Octal;

    /// <inheritdoc />
    [Required]
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = "255.255.255.255:255";

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
    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ON_STARTUP")]
    public DeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; } = DeviceTagGenerationOnStartupType.DoNotGenerateOnStartup;

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
    [Range(0, 65535)]
    [JsonPropertyName("productivity_3000_ethernet.DEVICE_PORT_NUMBER")]
    public int Port { get; set; } = 502;

    /// <inheritdoc />
    [JsonPropertyName("productivity_3000_ethernet.DEVICE_FIRST_WORD_HIGH")]
    public bool FirstWordHigh { get; set; } = true;

    /// <inheritdoc />
    [MaxLength(1024)]
    [JsonPropertyName("productivity_3000_ethernet.DEVICE_TAG_IMPORT_FILE")]
    public string? TagImportFile { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IdFormat)}: {IdFormat}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}
