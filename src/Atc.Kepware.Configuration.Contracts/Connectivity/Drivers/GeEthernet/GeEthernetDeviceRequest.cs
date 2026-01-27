namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.GeEthernet;

/// <summary>
/// GE Ethernet device request.
/// </summary>
public class GeEthernetDeviceRequest : DeviceRequestBase, IGeEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GeEthernetDeviceRequest"/> class.
    /// </summary>
    public GeEthernetDeviceRequest()
        : base(DriverType.GeEthernet)
    {
    }

    /// <inheritdoc />
    public GeEthernetModel Model { get; set; } = GeEthernetModel.PacSystems;
}
