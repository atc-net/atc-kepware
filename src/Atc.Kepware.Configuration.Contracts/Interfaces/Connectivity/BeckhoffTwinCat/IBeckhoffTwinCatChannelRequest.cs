namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.BeckhoffTwinCat;

/// <summary>
/// Interface for Beckhoff TwinCAT channel request.
/// </summary>
public interface IBeckhoffTwinCatChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Specify the name of a network adapter to bind or allow the OS to select the default.
    /// </summary>
    string? NetworkAdapter { get; set; }
}