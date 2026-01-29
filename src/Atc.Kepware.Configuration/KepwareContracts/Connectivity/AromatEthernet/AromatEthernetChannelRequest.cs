namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AromatEthernet;

/// <summary>
/// Aromat Ethernet channel request - Kepware format.
/// </summary>
internal sealed class AromatEthernetChannelRequest : ChannelRequestBase, IAromatEthernetChannelRequest
{
    public AromatEthernetChannelRequest()
        : base(DriverType.AromatEthernet)
    {
    }
}