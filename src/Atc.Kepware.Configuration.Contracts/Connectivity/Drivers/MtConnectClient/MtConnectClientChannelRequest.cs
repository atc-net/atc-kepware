namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MtConnectClient;

/// <summary>
/// Channel request properties for the MTConnect Client driver.
/// </summary>
/// <remarks>
/// The MTConnect Client driver has no channel-specific properties beyond the base channel properties.
/// </remarks>
public sealed class MtConnectClientChannelRequest : ChannelRequestBase, IMtConnectClientChannelRequest
{
    public MtConnectClientChannelRequest()
        : base(DriverType.MtConnectClient)
    {
    }
}