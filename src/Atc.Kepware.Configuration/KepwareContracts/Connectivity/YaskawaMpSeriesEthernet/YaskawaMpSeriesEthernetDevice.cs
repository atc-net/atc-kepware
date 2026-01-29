namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.YaskawaMpSeriesEthernet;

/// <summary>
/// Device properties for the Yaskawa MP Series Ethernet driver.
/// </summary>
internal sealed class YaskawaMpSeriesEthernetDevice : DeviceBase, IYaskawaMpSeriesEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = "255.255.255.255";

    [JsonPropertyName("yaskawa_mp_ethernet.DEVICE_PORT_NUMBER")]
    public int PortNumber { get; set; } = 502;

    [JsonPropertyName("yaskawa_mp_ethernet.DEVICE_INPUT_BITS")]
    public int InputBits { get; set; } = 32;

    [JsonPropertyName("yaskawa_mp_ethernet.DEVICE_OUTPUT_BITS")]
    public int OutputBits { get; set; } = 32;

    [JsonPropertyName("yaskawa_mp_ethernet.DEVICE_INPUT_WORDS")]
    public int InputWords { get; set; } = 32;

    [JsonPropertyName("yaskawa_mp_ethernet.DEVICE_OUTPUT_WORDS")]
    public int OutputWords { get; set; } = 32;

    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}, {nameof(InputBits)}: {InputBits}, {nameof(OutputBits)}: {OutputBits}, {nameof(InputWords)}: {InputWords}, {nameof(OutputWords)}: {OutputWords}";
}