namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.YokogawaDxpEthernet;

/// <summary>
/// Yokogawa DXP Ethernet channel request.
/// </summary>
internal sealed class YokogawaDxpEthernetChannelRequest : ChannelRequestBase, IYokogawaDxpEthernetChannelRequest
{
    public YokogawaDxpEthernetChannelRequest()
        : base(DriverType.YokogawaDxpEthernet)
    {
    }
}