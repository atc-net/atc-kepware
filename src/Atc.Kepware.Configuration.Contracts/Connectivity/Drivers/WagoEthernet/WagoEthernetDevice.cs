namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.WagoEthernet;

/// <summary>
/// Represents a Wago Ethernet device.
/// </summary>
public class WagoEthernetDevice : DeviceBase, IWagoEthernetDevice
{
    /// <inheritdoc />
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    public WagoEthernetDeviceModelType Model { get; set; } = WagoEthernetDeviceModelType.Model_750_342;

    /// <inheritdoc />
    public int PortNumber { get; set; } = 502;

    /// <inheritdoc />
    public int InputCoils { get; set; } = 32;

    /// <inheritdoc />
    public int OutputCoils { get; set; } = 32;

    /// <inheritdoc />
    public int InternalRegisters { get; set; } = 32;

    /// <inheritdoc />
    public int HoldingRegisters { get; set; } = 32;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}";
}
