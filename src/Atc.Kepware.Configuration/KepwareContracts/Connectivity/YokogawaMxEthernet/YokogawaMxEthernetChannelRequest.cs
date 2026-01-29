namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.YokogawaMxEthernet;

/// <summary>
/// Yokogawa MX Ethernet channel request - Kepware format.
/// </summary>
internal sealed class YokogawaMxEthernetChannelRequest : ChannelRequestBase, IYokogawaMxEthernetChannelRequest
{
    public YokogawaMxEthernetChannelRequest()
        : base(DriverType.YokogawaMxEthernet)
    {
    }
}