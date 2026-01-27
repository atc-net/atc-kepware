namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.GeEthernetGlobalData;

/// <summary>
/// GE Ethernet Global Data device request.
/// </summary>
public class GeEthernetGlobalDataDeviceRequest : DeviceRequestBase, IGeEthernetGlobalDataDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GeEthernetGlobalDataDeviceRequest"/> class.
    /// </summary>
    public GeEthernetGlobalDataDeviceRequest()
        : base(DriverType.GeEthernetGlobalData)
    {
    }

    /// <inheritdoc />
    public GeEthernetGlobalDataModel Model { get; set; } = GeEthernetGlobalDataModel.Egd;
}
