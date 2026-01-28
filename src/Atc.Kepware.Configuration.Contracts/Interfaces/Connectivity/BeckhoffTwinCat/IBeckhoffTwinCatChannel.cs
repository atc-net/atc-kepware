namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.BeckhoffTwinCat;

/// <summary>
/// Interface for Beckhoff TwinCAT channel.
/// </summary>
public interface IBeckhoffTwinCatChannel : IChannelBase
{
    /// <summary>
    /// Specify the name of a network adapter to bind or allow the OS to select the default.
    /// </summary>
    string? NetworkAdapter { get; set; }
}
