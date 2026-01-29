namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MemoryBased;

/// <summary>
/// Channel properties for the Memory Based driver.
/// </summary>
public sealed class MemoryBasedChannelRequest : ChannelRequestBase, IMemoryBasedChannelRequest
{
    public MemoryBasedChannelRequest()
        : base(DriverType.MemoryBased)
    {
    }

    /// <inheritdoc />
    public bool ItemPersistence { get; set; }

    /// <inheritdoc />
    public string? ItemPersistenceDataFile { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(ItemPersistence)}: {ItemPersistence}, {nameof(ItemPersistenceDataFile)}: {ItemPersistenceDataFile}";
}
