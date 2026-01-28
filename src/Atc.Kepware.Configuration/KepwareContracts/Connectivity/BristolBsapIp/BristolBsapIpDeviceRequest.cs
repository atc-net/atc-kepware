namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.BristolBsapIp;

/// <summary>
/// Device request properties for the Bristol BSAP IP driver.
/// </summary>
internal sealed class BristolBsapIpDeviceRequest : DeviceRequestBase, IBristolBsapIpDeviceRequest
{
    public BristolBsapIpDeviceRequest()
        : base(DriverType.BristolBsapIp)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public BristolBsapIpDeviceModelType Model { get; set; } = BristolBsapIpDeviceModelType.Dpc33Xx;

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("bristol_bsap_ip.DEVICE_RTU_GLOBAL_ADDRESS_HEX")]
    public int RtuGlobalAddress { get; set; }

    /// <inheritdoc />
    [Required]
    [MaxLength(15)]
    [JsonPropertyName("bristol_bsap_ip.DEVICE_RTU_IP_ADDRESS")]
    public string RtuIpAddress { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(1, 65535)]
    [JsonPropertyName("bristol_bsap_ip.DEVICE_RTU_UDP_PORT_NUMBER_DECIMAL")]
    public int RtuUdpPort { get; set; } = 1234;

    /// <inheritdoc />
    [Range(64, 256)]
    [JsonPropertyName("bristol_bsap_ip.DEVICE_MAXIMUM_BYTES_PER_REQUEST")]
    public int MaximumBytesPerRequest { get; set; } = 256;

    /// <inheritdoc />
    [JsonPropertyName("bristol_bsap_ip.DEVICE_LEVEL")]
    public BristolBsapIpDeviceLevelType Level { get; set; } = BristolBsapIpDeviceLevelType.Level1;

    /// <inheritdoc />
    [Range(100, 60000)]
    [JsonPropertyName("bristol_bsap_ip.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeoutMs { get; set; } = 1000;

    /// <inheritdoc />
    [Range(1, 10)]
    [JsonPropertyName("bristol_bsap_ip.DEVICE_FAIL_AFTER_SUCCESSIVE_TIMEOUTS")]
    public int FailAfterSuccessiveTimeouts { get; set; } = 3;

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
    [MaxLength(260)]
    [JsonPropertyName("bristol_bsap_ip.DEVICE_TAG_IMPORT_FILE")]
    public string? TagImportFile { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(RtuIpAddress)}: {RtuIpAddress}, {nameof(RtuUdpPort)}: {RtuUdpPort}, {nameof(Level)}: {Level}";
}
