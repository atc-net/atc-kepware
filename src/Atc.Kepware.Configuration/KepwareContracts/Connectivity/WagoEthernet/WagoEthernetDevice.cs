namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.WagoEthernet;

/// <summary>
/// Device properties for the Wago Ethernet driver.
/// </summary>
internal sealed class WagoEthernetDevice : DeviceBase, IWagoEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public WagoEthernetDeviceModelType Model { get; set; }

    [JsonPropertyName("wago_ethernet.DEVICE_PORT_NUMBER")]
    public int PortNumber { get; set; }

    [JsonPropertyName("wago_ethernet.DEVICE_INPUT_COILS")]
    public int InputCoils { get; set; }

    [JsonPropertyName("wago_ethernet.DEVICE_OUTPUT_COILS")]
    public int OutputCoils { get; set; }

    [JsonPropertyName("wago_ethernet.DEVICE_INTERNAL_REGISTERS")]
    public int InternalRegisters { get; set; }

    [JsonPropertyName("wago_ethernet.DEVICE_HOLDING_REGISTERS")]
    public int HoldingRegisters { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}";
}
