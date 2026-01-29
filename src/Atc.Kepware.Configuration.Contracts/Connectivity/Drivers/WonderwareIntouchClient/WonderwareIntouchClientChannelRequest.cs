namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.WonderwareIntouchClient;

/// <summary>
/// Represents a Wonderware InTouch Client channel creation request.
/// </summary>
/// <remarks>
/// The Wonderware InTouch Client driver does not have any driver-specific channel properties.
/// All channel configuration uses the standard base channel properties.
/// </remarks>
public class WonderwareIntouchClientChannelRequest : ChannelRequestBase, IWonderwareIntouchClientChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WonderwareIntouchClientChannelRequest"/> class.
    /// </summary>
    public WonderwareIntouchClientChannelRequest()
        : base(DriverType.WonderwareIntouchClient)
    {
    }

    /// <inheritdoc />
    public override string ToString()
        => base.ToString();
}