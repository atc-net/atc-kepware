namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.FanucFocasHssb;

/// <summary>
/// Channel properties for the Fanuc Focas HSSB driver.
/// </summary>
/// <remarks>
/// This driver has no channel-specific properties beyond the base channel properties.
/// </remarks>
public sealed class FanucFocasHssbChannel : ChannelBase, IFanucFocasHssbChannel
{
    /// <inheritdoc />
    public override string ToString()
        => base.ToString();
}