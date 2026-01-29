namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.SixnetEthertrak;

/// <summary>
/// Device properties for the SIXNET EtherTRAK driver.
/// </summary>
internal sealed class SixnetEthertrakDevice : DeviceBase, ISixnetEthertrakDevice
{
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

    [JsonPropertyName("ethertrak.DEVICE_PORT_NUMBER")]
    public int PortNumber { get; set; }

    [JsonPropertyName("ethertrak.DEVICE_OUTPUT_DISCRETES")]
    public int OutputDiscretes { get; set; }

    [JsonPropertyName("ethertrak.DEVICE_INPUT_DISCRETES")]
    public int InputDiscretes { get; set; }

    [JsonPropertyName("ethertrak.DEVICE_OUTPUT_REGISTERS")]
    public int OutputRegisters { get; set; }

    [JsonPropertyName("ethertrak.DEVICE_INPUT_REGISTERS")]
    public int InputRegisters { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}, {nameof(OutputDiscretes)}: {OutputDiscretes}, {nameof(InputDiscretes)}: {InputDiscretes}, {nameof(OutputRegisters)}: {OutputRegisters}, {nameof(InputRegisters)}: {InputRegisters}";
}
