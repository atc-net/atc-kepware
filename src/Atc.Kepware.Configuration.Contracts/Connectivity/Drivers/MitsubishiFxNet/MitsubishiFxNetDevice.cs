namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MitsubishiFxNet;

/// <summary>
/// Mitsubishi FX Net device.
/// </summary>
public class MitsubishiFxNetDevice : DeviceBase, IMitsubishiFxNetDevice
{
    /// <inheritdoc />
    public MitsubishiFxNetModel Model { get; set; } = MitsubishiFxNetModel.Fx;
}
