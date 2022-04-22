namespace Atc.Kepware.Configuration.Contracts.Drivers.EuroMap63;

/// <summary>
/// Channel properties for the EUROMAP 63 driver.
/// </summary>
public sealed class EuroMap63ChannelRequest : ChannelRequestBase, IEuroMap63ChannelRequest
{
    public EuroMap63ChannelRequest()
        : base(DriverType.EuroMap63)
    {
    }
}