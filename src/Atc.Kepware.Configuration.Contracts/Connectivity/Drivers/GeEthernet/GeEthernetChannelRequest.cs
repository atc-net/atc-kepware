namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.GeEthernet;

/// <summary>
/// GE Ethernet channel request.
/// </summary>
public class GeEthernetChannelRequest : ChannelRequestBase, IGeEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GeEthernetChannelRequest"/> class.
    /// </summary>
    public GeEthernetChannelRequest()
        : base(DriverType.GeEthernet)
    {
    }
}
