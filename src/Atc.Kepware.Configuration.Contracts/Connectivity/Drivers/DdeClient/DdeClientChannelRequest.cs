namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.DdeClient;

/// <summary>
/// Channel request properties for the DDE Client driver.
/// </summary>
/// <remarks>
/// The DDE Client driver has no driver-specific channel properties.
/// </remarks>
public sealed class DdeClientChannelRequest : ChannelRequestBase, IDdeClientChannelRequest
{
    public DdeClientChannelRequest()
        : base(DriverType.DdeClient)
    {
    }
}