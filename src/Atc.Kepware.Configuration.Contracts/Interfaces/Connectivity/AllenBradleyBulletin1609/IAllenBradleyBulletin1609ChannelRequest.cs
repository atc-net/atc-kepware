namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.AllenBradleyBulletin1609;

/// <summary>
/// Channel request properties for the Allen-Bradley Bulletin 1609 driver.
/// </summary>
public interface IAllenBradleyBulletin1609ChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Specify the name of a network adapter to bind or allow the OS to select the default.
    /// </summary>
    string? NetworkAdapter { get; set; }
}
