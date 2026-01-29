namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AllenBradleyBulletin900;

/// <summary>
/// Device request properties for the Allen-Bradley Bulletin 900 driver.
/// </summary>
internal sealed class AllenBradleyBulletin900DeviceRequest : DeviceRequestBase, IAllenBradleyBulletin900DeviceRequest
{
    public AllenBradleyBulletin900DeviceRequest()
        : base(DriverType.AllenBradleyBulletin900)
    {
    }

    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public Bulletin900DeviceModelType Model { get; set; } = Bulletin900DeviceModelType.Tc8;

    [JsonPropertyName("servermain.DEVICE_ID_DECIMAL")]
    public int DeviceId { get; set; } = 1;

    [JsonPropertyName("servermain.DEVICE_ETHERNET_COMMUNICATIONS_IP")]
    public string? IpAddress { get; set; }

    [JsonPropertyName("servermain.DEVICE_ETHERNET_COMMUNICATIONS_PORT")]
    public int EthernetPort { get; set; } = 2101;

    [JsonPropertyName("servermain.DEVICE_ETHERNET_COMMUNICATIONS_PROTOCOL")]
    public Bulletin900EthernetProtocolType EthernetProtocol { get; set; } = Bulletin900EthernetProtocolType.TcpIp;

    [JsonPropertyName("servermain.DEVICE_CONNECTION_TIMEOUT_SECONDS")]
    public int ConnectTimeoutSeconds { get; set; } = 3;

    [JsonPropertyName("servermain.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeoutMs { get; set; } = 1000;

    [JsonPropertyName("servermain.DEVICE_RETRY_ATTEMPTS")]
    public int RetryAttempts { get; set; } = 3;

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_ENABLE_ON_COMMUNICATIONS_FAILURES")]
    public bool DemoteOnFailure { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DEMOTE_AFTER_SUCCESSIVE_TIMEOUTS")]
    public int TimeoutsToDemote { get; set; } = 3;

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_PERIOD_MS")]
    public int DemotionPeriodMs { get; set; } = 10000;

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DISCARD_WRITES")]
    public bool DiscardRequestsWhenDemoted { get; set; }

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ON_STARTUP")]
    public DeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; } = DeviceTagGenerationOnStartupType.DoNotGenerateOnStartup;

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_DUPLICATE_HANDLING")]
    public DeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; } = DeviceTagGenerationDuplicateHandlingType.DeleteOnCreate;

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_GROUP")]
    public string? TagGenerationGroup { get; set; }

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ALLOW_SUB_GROUPS")]
    public bool AllowAutomaticallyGeneratedSubgroups { get; set; } = true;

    [JsonPropertyName("a-b_bulletin_900.DEVICE_PROCESS_VALUE_SCALING")]
    public bool ProcessValueScaling { get; set; }

    [JsonPropertyName("a-b_bulletin_900.DEVICE_PROCESS_VALUE_SCALING_FACTOR")]
    public float ProcessValueScalingFactor { get; set; } = 10f;

    [JsonPropertyName("a-b_bulletin_900.DEVICE_INPUT_TYPE")]
    public Bulletin900InputType InputType { get; set; } = Bulletin900InputType.TcPtMultiInput;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}";
}
