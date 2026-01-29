namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.BuswareEthernet;

/// <summary>
/// Represents a Busware Ethernet device.
/// </summary>
public class BuswareEthernetDevice : DeviceBase, IBuswareEthernetDevice
{
    /// <inheritdoc />
    public BuswareEthernetDeviceModelType Model { get; set; }

    /// <inheritdoc />
    public BuswareEthernetDeviceIdFormatType IdFormat { get; set; }

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
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}";
}