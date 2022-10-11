namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.EuroMap63;

/// <summary>
/// Channel properties for the EUROMAP 63 driver.
/// </summary>
internal class EuroMap63ChannelRequest : ChannelRequestBase
{
    public EuroMap63ChannelRequest()
        : base(DriverType.EuroMap63)
    {
    }
}