namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MitsubishiFxNet;

/// <summary>
/// Mitsubishi FX Net channel request.
/// </summary>
/// <remarks>
/// This is a serial-based driver with no driver-specific channel properties.
/// </remarks>
public class MitsubishiFxNetChannelRequest : ChannelRequestBase, IMitsubishiFxNetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MitsubishiFxNetChannelRequest"/> class.
    /// </summary>
    public MitsubishiFxNetChannelRequest()
        : base(DriverType.MitsubishiFxNet)
    {
    }
}
