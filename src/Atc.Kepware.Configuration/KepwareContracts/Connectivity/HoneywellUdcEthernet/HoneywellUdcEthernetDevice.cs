namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.HoneywellUdcEthernet;

/// <summary>
/// Device properties for the Honeywell UDC Ethernet driver.
/// </summary>
internal sealed class HoneywellUdcEthernetDevice : DeviceBase, IHoneywellUdcEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public HoneywellUdcEthernetDeviceModelType Model { get; set; }

    [JsonPropertyName("servermain.DEVICE_ID_FORMAT")]
    public HoneywellUdcEthernetDeviceIdFormatType IdFormat { get; set; }

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

    [JsonPropertyName("honeywell_udc_ethernet.DEVICE_PORT_NUMBER")]
    public int Port { get; set; }

    [JsonPropertyName("honeywell_udc_ethernet.DEVICE_FIRST_WORD_LOW")]
    public bool FirstWordLow { get; set; }

    [JsonPropertyName("honeywell_udc_ethernet.DEVICE_INTERNAL_REGISTERS")]
    public int InternalRegisters { get; set; }

    [JsonPropertyName("honeywell_udc_ethernet.DEVICE_HOLDING_REGISTERS")]
    public int HoldingRegisters { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IdFormat)}: {IdFormat}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}