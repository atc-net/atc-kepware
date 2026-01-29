namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.Opto22Ethernet;

/// <summary>
/// Device request for the Opto 22 Ethernet driver.
/// </summary>
internal sealed class Opto22EthernetDeviceRequest : DeviceRequestBase, IOpto22EthernetDeviceRequest
{
    public Opto22EthernetDeviceRequest()
        : base(DriverType.Opto22Ethernet)
    {
    }

    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public Opto22EthernetDeviceModelType Model { get; set; } = Opto22EthernetDeviceModelType.Opto22;

    [JsonPropertyName("servermain.DEVICE_ID_FORMAT")]
    public Opto22EthernetDeviceIdFormatType IdFormat { get; set; } = Opto22EthernetDeviceIdFormatType.Octal;

    [Required]
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = "255.255.255.255";

    [Range(1, 30)]
    [JsonPropertyName("servermain.DEVICE_CONNECTION_TIMEOUT_SECONDS")]
    public int ConnectTimeoutSeconds { get; set; } = 3;

    [Range(50, 9999999)]
    [JsonPropertyName("servermain.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeoutMs { get; set; } = 1000;

    [Range(1, 10)]
    [JsonPropertyName("servermain.DEVICE_RETRY_ATTEMPTS")]
    public int RetryAttempts { get; set; } = 3;

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_ENABLE_ON_COMMUNICATIONS_FAILURES")]
    public bool DemoteOnFailure { get; set; }

    [Range(1, 30)]
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DEMOTE_AFTER_SUCCESSIVE_TIMEOUTS")]
    public int TimeoutsToDemote { get; set; } = 3;

    [Range(100, 3600000)]
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_PERIOD_MS")]
    public int DemotionPeriodMs { get; set; } = 10000;

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DISCARD_WRITES")]
    public bool DiscardRequestsWhenDemoted { get; set; }

    [JsonPropertyName("opto22_ethernet.DEVICE_IO_UNIT_PROTOCOL")]
    public Opto22EthernetIoUnitProtocolType IoUnitProtocol { get; set; } = Opto22EthernetIoUnitProtocolType.TcpIp;

    [Range(1, 65535)]
    [JsonPropertyName("opto22_ethernet.DEVICE_IO_UNIT_PORT_NUMBER")]
    public int IoUnitPortNumber { get; set; } = 2001;

    [Range(1, 65535)]
    [JsonPropertyName("opto22_ethernet.DEVICE_CONTROL_ENGINE_PORT_NUMBER")]
    public int ControlEnginePortNumber { get; set; } = 22001;

    [JsonPropertyName("opto22_ethernet.DEVICE_IMPORT_FILE")]
    public string? ImportFile { get; set; }

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ON_STARTUP")]
    public Opto22EthernetTagGenerationOnStartupType TagGenerationOnStartup { get; set; } = Opto22EthernetTagGenerationOnStartupType.DoNotGenerateOnStartup;

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_DUPLICATE_HANDLING")]
    public Opto22EthernetTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; } = Opto22EthernetTagGenerationDuplicateHandlingType.DeleteOnCreate;

    [MaxLength(256)]
    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_GROUP")]
    public string? TagGenerationGroup { get; set; }

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ALLOW_SUB_GROUPS")]
    public bool AllowAutomaticallyGeneratedSubgroups { get; set; } = true;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(IoUnitPortNumber)}: {IoUnitPortNumber}";
}
