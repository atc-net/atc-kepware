namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.YokogawaDxEthernet;

/// <summary>
/// Yokogawa DX Ethernet channel request.
/// </summary>
internal sealed class YokogawaDxEthernetChannelRequest : ChannelRequestBase, IYokogawaDxEthernetChannelRequest
{
    public YokogawaDxEthernetChannelRequest()
        : base(DriverType.YokogawaDxEthernet)
    {
    }
}