namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.WonderwareIntouchClient;

/// <summary>
/// Represents a Wonderware InTouch Client channel.
/// </summary>
/// <remarks>
/// The Wonderware InTouch Client driver does not have any driver-specific channel properties.
/// All channel configuration uses the standard base channel properties.
/// </remarks>
public class WonderwareIntouchClientChannel : ChannelBase, IWonderwareIntouchClientChannel
{
    /// <inheritdoc />
    public override string ToString()
        => base.ToString();
}
