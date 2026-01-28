namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.CutlerHammerElcEthernet;

/// <summary>
/// Represents a Cutler-Hammer ELC Ethernet device.
/// </summary>
public class CutlerHammerElcEthernetDevice : DeviceBase, ICutlerHammerElcEthernetDevice
{
    /// <inheritdoc />
    public CutlerHammerElcEthernetDeviceModelType Model { get; set; }

    /// <inheritdoc />
    public CutlerHammerElcEthernetDeviceIdFormatType IdFormat { get; set; }

    /// <inheritdoc />
    public string DeviceId { get; set; } = "<255.255.255.255>.0";

    /// <inheritdoc />
    public int PortNumber { get; set; } = 502;

    /// <inheritdoc />
    public int OutputCoils { get; set; } = 1024;

    /// <inheritdoc />
    public int InputCoils { get; set; } = 1024;

    /// <inheritdoc />
    public int HoldingRegisters { get; set; } = 120;

    /// <inheritdoc />
    public bool FirstWordLow { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}";
}
