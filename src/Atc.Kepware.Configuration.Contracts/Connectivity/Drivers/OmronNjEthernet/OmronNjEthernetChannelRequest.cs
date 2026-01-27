namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.OmronNjEthernet;

/// <summary>
/// Omron NJ Ethernet channel request.
/// </summary>
public class OmronNjEthernetChannelRequest : ChannelRequestBase, IOmronNjEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OmronNjEthernetChannelRequest"/> class.
    /// </summary>
    public OmronNjEthernetChannelRequest()
        : base(DriverType.OmronNjEthernet)
    {
    }
}
