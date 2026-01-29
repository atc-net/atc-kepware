namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.GeEthernetGlobalData;

/// <summary>
/// GE Ethernet Global Data device - Kepware format.
/// </summary>
internal sealed class GeEthernetGlobalDataDevice : DeviceBase, IGeEthernetGlobalDataDevice
{
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public GeEthernetGlobalDataModel Model { get; set; } = GeEthernetGlobalDataModel.Egd;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}";
}