namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyBulletin1609;

/// <summary>
/// Channel request properties for the Allen-Bradley Bulletin 1609 driver.
/// </summary>
public sealed class AllenBradleyBulletin1609ChannelRequest : ChannelRequestBase, IAllenBradleyBulletin1609ChannelRequest
{
    public AllenBradleyBulletin1609ChannelRequest()
        : base(DriverType.AllenBradleyBulletin1609)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
