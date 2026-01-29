namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.FanucFocasHssb;

/// <summary>
/// Channel request properties for the Fanuc Focas HSSB driver.
/// </summary>
/// <remarks>
/// This driver has no channel-specific properties beyond the base channel request properties.
/// </remarks>
internal sealed class FanucFocasHssbChannelRequest : ChannelRequestBase, IFanucFocasHssbChannelRequest
{
    public FanucFocasHssbChannelRequest()
        : base(DriverType.FanucFocasHssb)
    {
    }

    /// <inheritdoc />
    public override string ToString()
        => base.ToString();
}
