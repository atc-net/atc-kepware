namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.SixnetEthertrak;

/// <summary>
/// Device request properties for the SIXNET EtherTRAK driver.
/// </summary>
internal sealed class SixnetEthertrakDeviceRequest : DeviceRequestBase, ISixnetEthertrakDeviceRequest
{
    public SixnetEthertrakDeviceRequest()
        : base(DriverType.SixnetEthertrak)
    {
    }

    /// <inheritdoc />
    [Required]
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("ethertrak.DEVICE_PORT_NUMBER")]
    public int PortNumber { get; set; } = 502;

    /// <inheritdoc />
    [Range(8, 800)]
    [JsonPropertyName("ethertrak.DEVICE_OUTPUT_DISCRETES")]
    public int OutputDiscretes { get; set; } = 32;

    /// <inheritdoc />
    [Range(8, 800)]
    [JsonPropertyName("ethertrak.DEVICE_INPUT_DISCRETES")]
    public int InputDiscretes { get; set; } = 32;

    /// <inheritdoc />
    [Range(1, 120)]
    [JsonPropertyName("ethertrak.DEVICE_OUTPUT_REGISTERS")]
    public int OutputRegisters { get; set; } = 32;

    /// <inheritdoc />
    [Range(1, 120)]
    [JsonPropertyName("ethertrak.DEVICE_INPUT_REGISTERS")]
    public int InputRegisters { get; set; } = 32;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}, {nameof(OutputDiscretes)}: {OutputDiscretes}, {nameof(InputDiscretes)}: {InputDiscretes}, {nameof(OutputRegisters)}: {OutputRegisters}, {nameof(InputRegisters)}: {InputRegisters}";
}
