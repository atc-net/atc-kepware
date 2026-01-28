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
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IdFormat)}: {IdFormat}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}
