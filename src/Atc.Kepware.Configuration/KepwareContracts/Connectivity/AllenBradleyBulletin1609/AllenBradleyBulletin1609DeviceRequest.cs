namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AllenBradleyBulletin1609;

/// <summary>
/// Device request properties for the Allen-Bradley Bulletin 1609 driver.
/// </summary>
internal sealed class AllenBradleyBulletin1609DeviceRequest : DeviceRequestBase, IAllenBradleyBulletin1609DeviceRequest
{
    public AllenBradleyBulletin1609DeviceRequest()
        : base(DriverType.AllenBradleyBulletin1609)
    {
    }

    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public Bulletin1609DeviceModelType Model { get; set; } = Bulletin1609DeviceModelType.Bulletin1609Ups;

    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = "255.255.255.255";

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

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ON_PROPERTY_CHANGE")]
    public bool TagGenerationOnPropertyChange { get; set; } = true;

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ON_STARTUP")]
    public DeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; } = DeviceTagGenerationOnStartupType.DoNotGenerateOnStartup;

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_DUPLICATE_HANDLING")]
    public DeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; } = DeviceTagGenerationDuplicateHandlingType.DeleteOnCreate;

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_GROUP")]
    public string? TagGenerationGroup { get; set; }

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ALLOW_SUB_GROUPS")]
    public bool AllowAutomaticallyGeneratedSubgroups { get; set; } = true;

    [JsonPropertyName("a-b_bulletin_1609.DEVICE_PORT_NUMBER")]
    public int Port { get; set; } = 161;

    [JsonPropertyName("a-b_bulletin_1609.DEVICE_IP_PROTOCOL")]
    public Bulletin1609IpProtocolType IpProtocol { get; set; } = Bulletin1609IpProtocolType.Udp;

    [JsonPropertyName("a-b_bulletin_1609.DEVICE_COMMUNITY")]
    public Bulletin1609CommunityType Community { get; set; } = Bulletin1609CommunityType.Private;

    [JsonPropertyName("a-b_bulletin_1609.DEVICE_CUSTOM_COMMUNITY")]
    public string? CustomCommunity { get; set; }

    [JsonPropertyName("a-b_bulletin_1609.DEVICE_NUMBER_OF_ITEMS_PER_MESSAGE")]
    public int NumberOfItemsPerMessage { get; set; } = 25;

    [JsonPropertyName("a-b_bulletin_1609.DEVICE_POST_NON_EXISTING_TAG_ERROR_MESSAGE")]
    public bool PostErrorsForNonExistingTags { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}