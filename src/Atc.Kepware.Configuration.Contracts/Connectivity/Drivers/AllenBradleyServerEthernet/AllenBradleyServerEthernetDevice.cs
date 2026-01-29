namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyServerEthernet;

/// <summary>
/// Allen-Bradley Server Ethernet device.
/// </summary>
public class AllenBradleyServerEthernetDevice : DeviceBase, IAllenBradleyServerEthernetDevice
{
    /// <inheritdoc />
    public int Port { get; set; } = 2222;

    /// <inheritdoc />
    public bool FirstWordLow { get; set; }
}