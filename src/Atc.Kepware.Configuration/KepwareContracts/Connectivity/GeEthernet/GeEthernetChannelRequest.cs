namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.GeEthernet;

/// <summary>
/// GE Ethernet channel request.
/// </summary>
internal sealed class GeEthernetChannelRequest : ChannelRequestBase, IGeEthernetChannelRequest
{
    public GeEthernetChannelRequest()
        : base(DriverType.GeEthernet)
    {
    }
}