namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.YokogawaDarwinEthernet;

/// <summary>
/// Yokogawa Darwin Ethernet channel request - Kepware format.
/// </summary>
internal sealed class YokogawaDarwinEthernetChannelRequest : ChannelRequestBase, IYokogawaDarwinEthernetChannelRequest
{
    public YokogawaDarwinEthernetChannelRequest()
        : base(DriverType.YokogawaDarwinEthernet)
    {
    }
}