namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AromatEthernet;

/// <summary>
/// Aromat Ethernet channel request.
/// </summary>
public class AromatEthernetChannelRequest : ChannelRequestBase, IAromatEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AromatEthernetChannelRequest"/> class.
    /// </summary>
    public AromatEthernetChannelRequest()
        : base(DriverType.AromatEthernet)
    {
    }
}
