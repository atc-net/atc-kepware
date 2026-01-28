namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AlstomRedundantEthernet;

/// <summary>
/// Device request properties for the Alstom Redundant Ethernet driver.
/// </summary>
internal sealed class AlstomRedundantEthernetDeviceRequest : DeviceRequestBase, IAlstomRedundantEthernetDeviceRequest
{
    public AlstomRedundantEthernetDeviceRequest()
        : base(DriverType.AlstomRedundantEthernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public AlstomRedundantEthernetDeviceModel Model { get; set; } = AlstomRedundantEthernetDeviceModel.IVpi;

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
    [Required]
    [MaxLength(15)]
    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_PRIMARY_NORMAL_IP")]
    public string PrimaryNormalIp { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_PRIMARY_NORMAL_PORT")]
    public int PrimaryNormalPort { get; set; } = 502;

    /// <inheritdoc />
    [Required]
    [MaxLength(15)]
    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_PRIMARY_STANDBY_IP")]
    public string PrimaryStandbyIp { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_PRIMARY_STANDBY_PORT")]
    public int PrimaryStandbyPort { get; set; } = 502;

    /// <inheritdoc />
    [Required]
    [MaxLength(15)]
    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_SECONDARY_NORMAL_IP")]
    public string SecondaryNormalIp { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_SECONDARY_NORMAL_PORT")]
    public int SecondaryNormalPort { get; set; } = 1502;

    /// <inheritdoc />
    [Required]
    [MaxLength(15)]
    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_SECONDARY_STANDBY_IP")]
    public string SecondaryStandbyIp { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_SECONDARY_STANDBY_PORT")]
    public int SecondaryStandbyPort { get; set; } = 1502;

    /// <inheritdoc />
    [Range(8, 2000)]
    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_OUTPUT_COILS")]
    public int OutputCoilsBlockSize { get; set; } = 8;

    /// <inheritdoc />
    [Range(8, 2000)]
    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_INPUT_COILS")]
    public int InputCoilsBlockSize { get; set; } = 8;

    /// <inheritdoc />
    [Range(1, 120)]
    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_INTERNAL_REGISTERS")]
    public int InternalRegistersBlockSize { get; set; } = 1;

    /// <inheritdoc />
    [Range(1, 120)]
    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_HOLDING_REGISTERS")]
    public int HoldingRegistersBlockSize { get; set; } = 1;

    /// <inheritdoc />
    [Range(1, 5)]
    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_RESET_AFTER")]
    public int InvalidSequenceNumbersBeforeReset { get; set; } = 5;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(PrimaryNormalIp)}: {PrimaryNormalIp}, {nameof(PrimaryNormalPort)}: {PrimaryNormalPort}";
}
