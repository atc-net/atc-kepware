namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SixnetEthertrak;

/// <summary>
/// Represents a SIXNET EtherTRAK device.
/// </summary>
public class SixnetEthertrakDevice : DeviceBase, ISixnetEthertrakDevice
{
    /// <inheritdoc />
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    public int PortNumber { get; set; } = 502;

    /// <inheritdoc />
    public int OutputDiscretes { get; set; } = 32;

    /// <inheritdoc />
    public int InputDiscretes { get; set; } = 32;

    /// <inheritdoc />
    public int OutputRegisters { get; set; } = 32;

    /// <inheritdoc />
    public int InputRegisters { get; set; } = 32;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}, {nameof(OutputDiscretes)}: {OutputDiscretes}, {nameof(InputDiscretes)}: {InputDiscretes}, {nameof(OutputRegisters)}: {OutputRegisters}, {nameof(InputRegisters)}: {InputRegisters}";
}
