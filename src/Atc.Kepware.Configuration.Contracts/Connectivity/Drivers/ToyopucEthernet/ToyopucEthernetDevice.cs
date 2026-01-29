namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.ToyopucEthernet;

/// <summary>
/// Represents a Toyopuc Ethernet device.
/// </summary>
public class ToyopucEthernetDevice : DeviceBase, IToyopucEthernetDevice
{
    /// <inheritdoc />
    public string DeviceId { get; set; } = "127.0.0.1";

    /// <inheritdoc />
    public ToyopucEthernetDeviceModelType Model { get; set; } = ToyopucEthernetDeviceModelType.Pc2_Pc2Interchange;

    /// <inheritdoc />
    public int DevicePort { get; set; } = 4096;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Model)}: {Model}";
}