namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.WonderwareIntouchClient;

/// <summary>
/// Channel properties for the Wonderware InTouch Client driver.
/// </summary>
/// <remarks>
/// The Wonderware InTouch Client driver does not have any driver-specific channel properties.
/// All channel configuration uses the standard base channel properties.
/// </remarks>
internal sealed class WonderwareIntouchClientChannel : ChannelBase, IWonderwareIntouchClientChannel
{
    /// <inheritdoc />
    public override string ToString()
        => base.ToString();
}
