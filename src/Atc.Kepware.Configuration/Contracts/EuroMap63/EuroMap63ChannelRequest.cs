namespace Atc.Kepware.Configuration.Contracts.EuroMap63;

/// <summary>
/// Channel properties for the EUROMAP 63 driver.
/// </summary>
public class EuroMap63ChannelRequest : ChannelRequestBase, IEuroMap63ChannelRequest
{
    public EuroMap63ChannelRequest()
        : base(DriverType.EuroMap63)
    {
    }
}