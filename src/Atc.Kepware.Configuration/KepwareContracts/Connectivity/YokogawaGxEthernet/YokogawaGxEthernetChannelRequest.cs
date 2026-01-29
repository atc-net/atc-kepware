namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.YokogawaGxEthernet;

/// <summary>
/// Yokogawa GX Ethernet channel request.
/// </summary>
internal sealed class YokogawaGxEthernetChannelRequest : ChannelRequestBase, IYokogawaGxEthernetChannelRequest
{
    public YokogawaGxEthernetChannelRequest()
        : base(DriverType.YokogawaGxEthernet)
    {
    }
}