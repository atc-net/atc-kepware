namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyBulletin1609;

/// <summary>
/// Channel properties for the Allen-Bradley Bulletin 1609 driver (response).
/// </summary>
public sealed class AllenBradleyBulletin1609Channel : ChannelBase
{
    /// <summary>
    /// Specify the name of a network adapter to bind or allow the OS to select the default.
    /// </summary>
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
