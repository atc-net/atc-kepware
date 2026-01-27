namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.GeEthernet;

/// <summary>
/// GE Ethernet device - Kepware format.
/// </summary>
internal sealed class GeEthernetDevice : DeviceBase, IGeEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public GeEthernetModel Model { get; set; } = GeEthernetModel.PacSystems;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}";
}
