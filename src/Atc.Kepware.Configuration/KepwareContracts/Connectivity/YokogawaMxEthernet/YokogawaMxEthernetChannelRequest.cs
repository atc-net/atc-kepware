namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.YokogawaMxEthernet;

/// <summary>
/// Yokogawa MX Ethernet channel request.
/// </summary>
internal sealed class YokogawaMxEthernetChannelRequest : ChannelRequestBase, IYokogawaMxEthernetChannelRequest
{
    public YokogawaMxEthernetChannelRequest()
        : base(DriverType.YokogawaMxEthernet)
    {
    }
}