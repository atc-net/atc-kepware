namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MitsubishiFxNet;

/// <summary>
/// Mitsubishi FX Net channel request - Kepware format.
/// </summary>
internal sealed class MitsubishiFxNetChannelRequest : ChannelRequestBase, IMitsubishiFxNetChannelRequest
{
    public MitsubishiFxNetChannelRequest()
        : base(DriverType.MitsubishiFxNet)
    {
    }
}