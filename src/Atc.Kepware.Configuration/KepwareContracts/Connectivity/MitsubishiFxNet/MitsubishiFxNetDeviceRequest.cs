namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MitsubishiFxNet;

/// <summary>
/// Mitsubishi FX Net device request - Kepware format.
/// </summary>
internal sealed class MitsubishiFxNetDeviceRequest : DeviceRequestBase, IMitsubishiFxNetDeviceRequest
{
    public MitsubishiFxNetDeviceRequest()
        : base(DriverType.MitsubishiFxNet)
    {
    }

    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public MitsubishiFxNetModel Model { get; set; } = MitsubishiFxNetModel.Fx;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}";
}
