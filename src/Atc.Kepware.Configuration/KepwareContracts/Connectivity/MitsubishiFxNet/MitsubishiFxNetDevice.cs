namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MitsubishiFxNet;

/// <summary>
/// Mitsubishi FX Net device - Kepware format.
/// </summary>
internal sealed class MitsubishiFxNetDevice : DeviceBase, IMitsubishiFxNetDevice
{
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public MitsubishiFxNetModel Model { get; set; } = MitsubishiFxNetModel.Fx;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}";
}
