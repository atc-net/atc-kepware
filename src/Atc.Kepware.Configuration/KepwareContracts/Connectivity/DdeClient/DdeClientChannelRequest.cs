namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.DdeClient;

/// <summary>
/// Channel request properties for the DDE Client driver.
/// </summary>
/// <remarks>
/// The DDE Client driver has no driver-specific channel properties.
/// </remarks>
internal sealed class DdeClientChannelRequest : ChannelRequestBase, IDdeClientChannelRequest
{
    public DdeClientChannelRequest()
        : base(DriverType.DdeClient)
    {
    }
}
