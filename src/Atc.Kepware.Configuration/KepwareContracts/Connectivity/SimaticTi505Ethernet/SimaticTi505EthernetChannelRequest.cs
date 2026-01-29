namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.SimaticTi505Ethernet;

/// <summary>
/// Simatic/TI 505 Ethernet channel request.
/// </summary>
internal sealed class SimaticTi505EthernetChannelRequest : ChannelRequestBase, ISimaticTi505EthernetChannelRequest
{
    public SimaticTi505EthernetChannelRequest()
        : base(DriverType.SimaticTi505Ethernet)
    {
    }
}