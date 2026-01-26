namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AllenBradleyEthernet;

/// <summary>
/// Internal model for Allen-Bradley Ethernet channel request to Kepware API.
/// </summary>
internal sealed class AllenBradleyEthernetChannelRequest : ChannelRequestBase
{
    public AllenBradleyEthernetChannelRequest()
        : base(DriverType.AllenBradleyEthernet)
    {
    }
}
