namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyServerEthernet;

/// <summary>
/// Allen-Bradley Server Ethernet channel request.
/// </summary>
public class AllenBradleyServerEthernetChannelRequest : ChannelRequestBase, IAllenBradleyServerEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AllenBradleyServerEthernetChannelRequest"/> class.
    /// </summary>
    public AllenBradleyServerEthernetChannelRequest()
        : base(DriverType.AllenBradleyServerEthernet)
    {
    }
}
