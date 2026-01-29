namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.BuswareEthernet;

/// <summary>
/// Device request properties for the Busware Ethernet driver.
/// </summary>
internal sealed class BuswareEthernetDeviceRequest : DeviceRequestBase, IBuswareEthernetDeviceRequest
{
    public BuswareEthernetDeviceRequest()
        : base(DriverType.BuswareEthernet)
    {
    }

    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public BuswareEthernetDeviceModelType Model { get; set; } = BuswareEthernetDeviceModelType.BuswareEthernet;

    [JsonPropertyName("servermain.DEVICE_ID_FORMAT")]
    public BuswareEthernetDeviceIdFormatType IdFormat { get; set; } = BuswareEthernetDeviceIdFormatType.Octal;

    /// <inheritdoc />
    [Required]
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("busware_ethernet.DEVICE_PORT_NUMBER")]
    public int PortNumber { get; set; } = 502;

    /// <inheritdoc />
    [Range(8, 800)]
    [JsonPropertyName("busware_ethernet.DEVICE_OUTPUT_DISCRETES")]
    public int OutputDiscretes { get; set; } = 32;

    /// <inheritdoc />
    [Range(8, 800)]
    [JsonPropertyName("busware_ethernet.DEVICE_INPUT_DISCRETES")]
    public int InputDiscretes { get; set; } = 32;

    /// <inheritdoc />
    [Range(1, 120)]
    [JsonPropertyName("busware_ethernet.DEVICE_OUTPUT_REGISTERS")]
    public int OutputRegisters { get; set; } = 32;

    /// <inheritdoc />
    [Range(1, 120)]
    [JsonPropertyName("busware_ethernet.DEVICE_INPUT_REGISTERS")]
    public int InputRegisters { get; set; } = 32;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}";
}
