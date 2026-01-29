namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.WagoEthernet;

/// <summary>
/// Device request properties for the Wago Ethernet driver.
/// </summary>
internal sealed class WagoEthernetDeviceRequest : DeviceRequestBase, IWagoEthernetDeviceRequest
{
    public WagoEthernetDeviceRequest()
        : base(DriverType.WagoEthernet)
    {
    }

    /// <inheritdoc />
    [Required]
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public WagoEthernetDeviceModelType Model { get; set; } = WagoEthernetDeviceModelType.Model_750_342;

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("wago_ethernet.DEVICE_PORT_NUMBER")]
    public int PortNumber { get; set; } = 502;

    /// <inheritdoc />
    [Range(8, 800)]
    [JsonPropertyName("wago_ethernet.DEVICE_INPUT_COILS")]
    public int InputCoils { get; set; } = 32;

    /// <inheritdoc />
    [Range(8, 800)]
    [JsonPropertyName("wago_ethernet.DEVICE_OUTPUT_COILS")]
    public int OutputCoils { get; set; } = 32;

    /// <inheritdoc />
    [Range(1, 120)]
    [JsonPropertyName("wago_ethernet.DEVICE_INTERNAL_REGISTERS")]
    public int InternalRegisters { get; set; } = 32;

    /// <inheritdoc />
    [Range(1, 120)]
    [JsonPropertyName("wago_ethernet.DEVICE_HOLDING_REGISTERS")]
    public int HoldingRegisters { get; set; } = 32;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}";
}
