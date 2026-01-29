namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.OmronNjEthernet;

/// <summary>
/// Omron NJ Ethernet channel request - Kepware format.
/// </summary>
internal sealed class OmronNjEthernetChannelRequest : ChannelRequestBase, IOmronNjEthernetChannelRequest
{
    public OmronNjEthernetChannelRequest()
        : base(DriverType.OmronNjEthernet)
    {
    }
}