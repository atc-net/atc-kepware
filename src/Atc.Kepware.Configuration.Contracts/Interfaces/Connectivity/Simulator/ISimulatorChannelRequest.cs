namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.Simulator;

/// <summary>
/// Channel properties for the Simulator driver.
/// </summary>
public interface ISimulatorChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Enable this option to save on shutdown and restore on startup of R, K, and S address contents.
    /// </summary>
    bool ItemPersistence { get; set; }

    /// <summary>
    /// The path and file name where item persistence data should be saved.
    /// </summary>
    string? ItemPersistenceDataFile { get; set; }
}