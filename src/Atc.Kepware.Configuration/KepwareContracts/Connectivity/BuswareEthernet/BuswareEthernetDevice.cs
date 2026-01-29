namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.BuswareEthernet;

/// <summary>
/// Device properties for the Busware Ethernet driver.
/// </summary>
internal sealed class BuswareEthernetDevice : DeviceBase, IBuswareEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public BuswareEthernetDeviceModelType Model { get; set; }

    [JsonPropertyName("servermain.DEVICE_ID_FORMAT")]
    public BuswareEthernetDeviceIdFormatType IdFormat { get; set; }

    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

    [JsonPropertyName("busware_ethernet.DEVICE_PORT_NUMBER")]
    public int PortNumber { get; set; }

    [JsonPropertyName("busware_ethernet.DEVICE_OUTPUT_DISCRETES")]
    public int OutputDiscretes { get; set; }

    [JsonPropertyName("busware_ethernet.DEVICE_INPUT_DISCRETES")]
    public int InputDiscretes { get; set; }

    [JsonPropertyName("busware_ethernet.DEVICE_OUTPUT_REGISTERS")]
    public int OutputRegisters { get; set; }

    [JsonPropertyName("busware_ethernet.DEVICE_INPUT_REGISTERS")]
    public int InputRegisters { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}";
}