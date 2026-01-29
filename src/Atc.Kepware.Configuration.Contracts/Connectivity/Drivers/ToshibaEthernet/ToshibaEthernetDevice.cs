namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.ToshibaEthernet;

/// <summary>
/// Represents a Toshiba Ethernet device.
/// </summary>
public class ToshibaEthernetDevice : DeviceBase, IToshibaEthernetDevice
{
    /// <inheritdoc />
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    public int PortNumber { get; set; } = 1024;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}";
}