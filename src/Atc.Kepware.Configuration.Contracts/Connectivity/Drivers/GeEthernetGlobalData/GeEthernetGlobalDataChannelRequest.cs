namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.GeEthernetGlobalData;

/// <summary>
/// GE Ethernet Global Data channel request.
/// </summary>
public class GeEthernetGlobalDataChannelRequest : ChannelRequestBase, IGeEthernetGlobalDataChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GeEthernetGlobalDataChannelRequest"/> class.
    /// </summary>
    public GeEthernetGlobalDataChannelRequest()
        : base(DriverType.GeEthernetGlobalData)
    {
    }
}
