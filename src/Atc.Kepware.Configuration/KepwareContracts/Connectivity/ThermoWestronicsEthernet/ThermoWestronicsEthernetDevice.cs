namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.ThermoWestronicsEthernet;

/// <summary>
/// Thermo Westronics Ethernet device.
/// </summary>
internal sealed class ThermoWestronicsEthernetDevice : DeviceBase, IThermoWestronicsEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

    [JsonPropertyName("servermain.DEVICE_CONNECTION_TIMEOUT_SECONDS")]
    public int ConnectTimeoutSeconds { get; set; }

    [JsonPropertyName("servermain.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeoutMs { get; set; }

    [JsonPropertyName("servermain.DEVICE_RETRY_ATTEMPTS")]
    public int RetryAttempts { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_ENABLE_ON_COMMUNICATIONS_FAILURES")]
    public bool DemoteOnFailure { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DEMOTE_AFTER_SUCCESSIVE_TIMEOUTS")]
    public int TimeoutsToDemote { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_PERIOD_MS")]
    public int DemotionPeriodMs { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DISCARD_WRITES")]
    public bool DiscardRequestsWhenDemoted { get; set; }

    [JsonPropertyName("thermowestronics_ethernet.DEVICE_PORT_NUMBER")]
    public int Port { get; set; }

    [JsonPropertyName("thermowestronics_ethernet.DEVICE_OUTPUT_COILS")]
    public int OutputCoils { get; set; }

    [JsonPropertyName("thermowestronics_ethernet.DEVICE_INPUT_COILS")]
    public int InputCoils { get; set; }

    [JsonPropertyName("thermowestronics_ethernet.DEVICE_INTERNAL_REGISTERS")]
    public int InternalRegisters { get; set; }

    [JsonPropertyName("thermowestronics_ethernet.DEVICE_HOLDING_REGISTERS")]
    public int HoldingRegisters { get; set; }

    [JsonPropertyName("thermowestronics_ethernet.DEVICE_USE_1X32_FLOAT_FORMAT")]
    public bool Use1x32FloatFormat { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}