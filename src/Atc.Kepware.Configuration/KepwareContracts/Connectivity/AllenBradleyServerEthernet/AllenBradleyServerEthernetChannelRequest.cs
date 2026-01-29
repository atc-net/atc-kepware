namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AllenBradleyServerEthernet;

/// <summary>
/// Allen-Bradley Server Ethernet channel request.
/// </summary>
internal sealed class AllenBradleyServerEthernetChannelRequest : ChannelRequestBase, IAllenBradleyServerEthernetChannelRequest
{
    public AllenBradleyServerEthernetChannelRequest()
        : base(DriverType.AllenBradleyServerEthernet)
    {
    }
}