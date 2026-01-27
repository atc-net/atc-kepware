namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.GeEthernetGlobalData;

/// <summary>
/// GE Ethernet Global Data device.
/// </summary>
public class GeEthernetGlobalDataDevice : DeviceBase, IGeEthernetGlobalDataDevice
{
    /// <inheritdoc />
    public GeEthernetGlobalDataModel Model { get; set; } = GeEthernetGlobalDataModel.Egd;
}
