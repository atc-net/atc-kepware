namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MtConnectClient;

/// <summary>
/// Channel request properties for the MTConnect Client driver.
/// </summary>
/// <remarks>
/// The MTConnect Client driver has no channel-specific properties beyond the base channel properties.
/// </remarks>
internal class MtConnectClientChannelRequest : ChannelRequestBase
{
    public MtConnectClientChannelRequest()
        : base(DriverType.MtConnectClient)
    {
    }
}