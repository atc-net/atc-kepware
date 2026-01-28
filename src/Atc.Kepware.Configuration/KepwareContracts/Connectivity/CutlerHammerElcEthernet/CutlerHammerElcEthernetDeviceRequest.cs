namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.CutlerHammerElcEthernet;

/// <summary>
/// Device request properties for the Cutler-Hammer ELC Ethernet driver.
/// </summary>
internal sealed class CutlerHammerElcEthernetDeviceRequest : DeviceRequestBase, ICutlerHammerElcEthernetDeviceRequest
{
    public CutlerHammerElcEthernetDeviceRequest()
        : base(DriverType.CutlerHammerElcEthernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public CutlerHammerElcEthernetDeviceModelType Model { get; set; } = CutlerHammerElcEthernetDeviceModelType.Pv28Series;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_ID_FORMAT")]
    public CutlerHammerElcEthernetDeviceIdFormatType IdFormat { get; set; } = CutlerHammerElcEthernetDeviceIdFormatType.Octal;

    /// <inheritdoc />
    [Required]
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = "<255.255.255.255>.0";

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("cutlerhammer_elc_ethernet.DEVICE_PORT_NUMBER")]
    public int PortNumber { get; set; } = 502;

    /// <inheritdoc />
    [Range(8, 1024)]
    [JsonPropertyName("cutlerhammer_elc_ethernet.DEVICE_OUTPUT_COILS")]
    public int OutputCoils { get; set; } = 1024;

    /// <inheritdoc />
    [Range(8, 1024)]
    [JsonPropertyName("cutlerhammer_elc_ethernet.DEVICE_INPUT_COILS")]
    public int InputCoils { get; set; } = 1024;

    /// <inheritdoc />
    [Range(1, 120)]
    [JsonPropertyName("cutlerhammer_elc_ethernet.DEVICE_HOLDING_REGISTERS")]
    public int HoldingRegisters { get; set; } = 120;

    /// <inheritdoc />
    [JsonPropertyName("cutlerhammer_elc_ethernet.DEVICE_FIRST_WORD_LOW")]
    public bool FirstWordLow { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}";
}
