namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.OmronNjEthernet;

/// <summary>
/// Omron NJ Ethernet channel request.
/// </summary>
internal sealed class OmronNjEthernetChannelRequest : ChannelRequestBase, IOmronNjEthernetChannelRequest
{
    public OmronNjEthernetChannelRequest()
        : base(DriverType.OmronNjEthernet)
    {
    }
}