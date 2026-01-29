namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AutomationDirectEcom;

/// <summary>
/// Device request properties for the AutomationDirect ECOM driver.
/// </summary>
internal sealed class AutomationDirectEcomDeviceRequest : DeviceRequestBase, IAutomationDirectEcomDeviceRequest
{
    public AutomationDirectEcomDeviceRequest()
        : base(DriverType.AutomationDirectEcom)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public AutomationDirectEcomDeviceModelType Model { get; set; } = AutomationDirectEcomDeviceModelType.Dl05;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_ID_FORMAT")]
    public AutomationDirectEcomDeviceIdFormatType IdFormat { get; set; } = AutomationDirectEcomDeviceIdFormatType.Octal;

    /// <inheritdoc />
    [Required]
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = "255.255.255.255";

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
    [JsonPropertyName("plcdirect_ecom.DEVICE_PORT_NUMBER")]
    public int Port { get; set; } = 28784;

    /// <inheritdoc />
    [MaxLength(1024)]
    [JsonPropertyName("plcdirect_ecom.DEVICE_TAG_IMPORT_FILE")]
    public string? TagImportFile { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("plcdirect_ecom.DEVICE_DISPLAY_DESCRIPTIONS")]
    public bool DisplayDescriptions { get; set; } = true;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IdFormat)}: {IdFormat}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}