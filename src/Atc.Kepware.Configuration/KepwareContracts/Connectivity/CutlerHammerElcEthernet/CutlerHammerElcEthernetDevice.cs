namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.CutlerHammerElcEthernet;

/// <summary>
/// Device properties for the Cutler-Hammer ELC Ethernet driver.
/// </summary>
internal sealed class CutlerHammerElcEthernetDevice : DeviceBase, ICutlerHammerElcEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public CutlerHammerElcEthernetDeviceModelType Model { get; set; }

    [JsonPropertyName("servermain.DEVICE_ID_FORMAT")]
    public CutlerHammerElcEthernetDeviceIdFormatType IdFormat { get; set; }

    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

    [JsonPropertyName("cutlerhammer_elc_ethernet.DEVICE_PORT_NUMBER")]
    public int PortNumber { get; set; }

    [JsonPropertyName("cutlerhammer_elc_ethernet.DEVICE_OUTPUT_COILS")]
    public int OutputCoils { get; set; }

    [JsonPropertyName("cutlerhammer_elc_ethernet.DEVICE_INPUT_COILS")]
    public int InputCoils { get; set; }

    [JsonPropertyName("cutlerhammer_elc_ethernet.DEVICE_HOLDING_REGISTERS")]
    public int HoldingRegisters { get; set; }

    [JsonPropertyName("cutlerhammer_elc_ethernet.DEVICE_FIRST_WORD_LOW")]
    public bool FirstWordLow { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}";
}
