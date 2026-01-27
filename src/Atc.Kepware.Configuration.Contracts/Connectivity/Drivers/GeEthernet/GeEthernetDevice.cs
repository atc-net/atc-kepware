namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.GeEthernet;

/// <summary>
/// GE Ethernet device.
/// </summary>
public class GeEthernetDevice : DeviceBase, IGeEthernetDevice
{
    /// <inheritdoc />
    public GeEthernetModel Model { get; set; } = GeEthernetModel.PacSystems;
}
