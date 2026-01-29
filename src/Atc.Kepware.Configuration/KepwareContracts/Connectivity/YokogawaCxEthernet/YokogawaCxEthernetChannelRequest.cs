namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.YokogawaCxEthernet;

/// <summary>
/// Yokogawa CX Ethernet channel request.
/// </summary>
internal sealed class YokogawaCxEthernetChannelRequest : ChannelRequestBase, IYokogawaCxEthernetChannelRequest
{
    public YokogawaCxEthernetChannelRequest()
        : base(DriverType.YokogawaCxEthernet)
    {
    }
}