namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.GeEthernetGlobalData;

/// <summary>
/// GE Ethernet Global Data device request - Kepware format.
/// </summary>
internal sealed class GeEthernetGlobalDataDeviceRequest : DeviceRequestBase, IGeEthernetGlobalDataDeviceRequest
{
    public GeEthernetGlobalDataDeviceRequest()
        : base(DriverType.GeEthernetGlobalData)
    {
    }

    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public GeEthernetGlobalDataModel Model { get; set; } = GeEthernetGlobalDataModel.Egd;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}";
}
