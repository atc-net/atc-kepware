namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.ThermoWestronicsEthernet;

/// <summary>
/// Thermo Westronics Ethernet device request - Kepware format.
/// </summary>
internal sealed class ThermoWestronicsEthernetDeviceRequest : DeviceRequestBase, IThermoWestronicsEthernetDeviceRequest
{
    public ThermoWestronicsEthernetDeviceRequest()
        : base(DriverType.ThermoWestronicsEthernet)
    {
    }

    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

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

    [JsonPropertyName("thermowestronics_ethernet.DEVICE_PORT_NUMBER")]
    public int Port { get; set; } = 502;

    [JsonPropertyName("thermowestronics_ethernet.DEVICE_OUTPUT_COILS")]
    public int OutputCoils { get; set; } = 32;

    [JsonPropertyName("thermowestronics_ethernet.DEVICE_INPUT_COILS")]
    public int InputCoils { get; set; } = 32;

    [JsonPropertyName("thermowestronics_ethernet.DEVICE_INTERNAL_REGISTERS")]
    public int InternalRegisters { get; set; } = 32;

    [JsonPropertyName("thermowestronics_ethernet.DEVICE_HOLDING_REGISTERS")]
    public int HoldingRegisters { get; set; } = 32;

    [JsonPropertyName("thermowestronics_ethernet.DEVICE_USE_1X32_FLOAT_FORMAT")]
    public bool Use1x32FloatFormat { get; set; } = true;

    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}