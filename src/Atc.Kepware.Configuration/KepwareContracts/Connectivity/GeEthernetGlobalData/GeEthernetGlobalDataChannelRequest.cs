namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.GeEthernetGlobalData;

/// <summary>
/// GE Ethernet Global Data channel request.
/// </summary>
internal sealed class GeEthernetGlobalDataChannelRequest : ChannelRequestBase, IGeEthernetGlobalDataChannelRequest
{
    public GeEthernetGlobalDataChannelRequest()
        : base(DriverType.GeEthernetGlobalData)
    {
    }
}