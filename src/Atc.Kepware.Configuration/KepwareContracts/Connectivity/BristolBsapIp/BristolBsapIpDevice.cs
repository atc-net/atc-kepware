namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.BristolBsapIp;

/// <summary>
/// Device properties for the Bristol BSAP IP driver.
/// </summary>
internal sealed class BristolBsapIpDevice : DeviceBase, IBristolBsapIpDevice
{
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public BristolBsapIpDeviceModelType Model { get; set; }

    [JsonPropertyName("bristol_bsap_ip.DEVICE_RTU_GLOBAL_ADDRESS_HEX")]
    public int RtuGlobalAddress { get; set; }

    [JsonPropertyName("bristol_bsap_ip.DEVICE_RTU_IP_ADDRESS")]
    public string RtuIpAddress { get; set; } = string.Empty;

    [JsonPropertyName("bristol_bsap_ip.DEVICE_RTU_UDP_PORT_NUMBER_DECIMAL")]
    public int RtuUdpPort { get; set; }

    [JsonPropertyName("bristol_bsap_ip.DEVICE_MAXIMUM_BYTES_PER_REQUEST")]
    public int MaximumBytesPerRequest { get; set; }

    [JsonPropertyName("bristol_bsap_ip.DEVICE_LEVEL")]
    public BristolBsapIpDeviceLevelType Level { get; set; }

    [JsonPropertyName("bristol_bsap_ip.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeoutMs { get; set; }

    [JsonPropertyName("bristol_bsap_ip.DEVICE_FAIL_AFTER_SUCCESSIVE_TIMEOUTS")]
    public int FailAfterSuccessiveTimeouts { get; set; }

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

    [JsonPropertyName("bristol_bsap_ip.DEVICE_TAG_IMPORT_FILE")]
    public string? TagImportFile { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(RtuIpAddress)}: {RtuIpAddress}, {nameof(RtuUdpPort)}: {RtuUdpPort}, {nameof(Level)}: {Level}";
}
