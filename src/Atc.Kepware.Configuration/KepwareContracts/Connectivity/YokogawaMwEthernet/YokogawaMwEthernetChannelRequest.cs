namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.YokogawaMwEthernet;

/// <summary>
/// Yokogawa MW Ethernet channel request - Kepware format.
/// </summary>
internal sealed class YokogawaMwEthernetChannelRequest : ChannelRequestBase, IYokogawaMwEthernetChannelRequest
{
    public YokogawaMwEthernetChannelRequest()
        : base(DriverType.YokogawaMwEthernet)
    {
    }
}
