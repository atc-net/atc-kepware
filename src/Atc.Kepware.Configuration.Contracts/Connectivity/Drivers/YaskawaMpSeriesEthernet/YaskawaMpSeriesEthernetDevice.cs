namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.YaskawaMpSeriesEthernet;

/// <summary>
/// Represents a Yaskawa MP Series Ethernet device.
/// </summary>
public class YaskawaMpSeriesEthernetDevice : DeviceBase, IYaskawaMpSeriesEthernetDevice
{
    /// <inheritdoc />
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    public int PortNumber { get; set; } = 502;

    /// <inheritdoc />
    public int InputBits { get; set; } = 32;

    /// <inheritdoc />
    public int OutputBits { get; set; } = 32;

    /// <inheritdoc />
    public int InputWords { get; set; } = 32;

    /// <inheritdoc />
    public int OutputWords { get; set; } = 32;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}, {nameof(InputBits)}: {InputBits}, {nameof(OutputBits)}: {OutputBits}, {nameof(InputWords)}: {InputWords}, {nameof(OutputWords)}: {OutputWords}";
}