namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.FanucFocasHssb;

/// <summary>
/// Channel request properties for the Fanuc Focas HSSB driver.
/// </summary>
/// <remarks>
/// This driver has no channel-specific properties beyond the base channel request properties.
/// </remarks>
public sealed class FanucFocasHssbChannelRequest : ChannelRequestBase, IFanucFocasHssbChannelRequest
{
    public FanucFocasHssbChannelRequest()
        : base(DriverType.FanucFocasHssb)
    {
    }

    /// <inheritdoc />
    public override string ToString()
        => base.ToString();
}