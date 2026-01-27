namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MitsubishiFxNet;

/// <summary>
/// Mitsubishi FX Net device request.
/// </summary>
public class MitsubishiFxNetDeviceRequest : DeviceRequestBase, IMitsubishiFxNetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MitsubishiFxNetDeviceRequest"/> class.
    /// </summary>
    public MitsubishiFxNetDeviceRequest()
        : base(DriverType.MitsubishiFxNet)
    {
    }

    /// <inheritdoc />
    public MitsubishiFxNetModel Model { get; set; } = MitsubishiFxNetModel.Fx;
}
