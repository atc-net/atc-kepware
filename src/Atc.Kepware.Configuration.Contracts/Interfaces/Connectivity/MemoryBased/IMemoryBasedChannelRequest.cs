namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.MemoryBased;

/// <summary>
/// Channel properties for the Memory Based driver.
/// </summary>
public interface IMemoryBasedChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Enable this option to cause the driver to persist all tags to disk between server runs.
    /// </summary>
    bool ItemPersistence { get; set; }

    /// <summary>
    /// The fully-qualified path and file name where the driver will persist tags between server runs.
    /// </summary>
    string? ItemPersistenceDataFile { get; set; }
}