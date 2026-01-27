namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.GeEthernet;

/// <summary>
/// GE Ethernet device request - Kepware format.
/// </summary>
internal sealed class GeEthernetDeviceRequest : DeviceRequestBase, IGeEthernetDeviceRequest
{
    public GeEthernetDeviceRequest()
        : base(DriverType.GeEthernet)
    {
    }

    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public GeEthernetModel Model { get; set; } = GeEthernetModel.PacSystems;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}";
}
