namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MemoryBased;

/// <summary>
/// Channel properties for the Memory Based driver.
/// </summary>
internal class MemoryBasedChannelRequest : ChannelRequestBase, IMemoryBasedChannelRequest
{
    public MemoryBasedChannelRequest()
        : base(DriverType.MemoryBased)
    {
    }

    [JsonPropertyName("memory_based.CHANNEL_ITEM_PERSISTENCE")]
    public bool ItemPersistence { get; set; }

    [JsonPropertyName("memory_based.CHANNEL_ITEM_PERSISTENCE_DATA_FILE")]
    public string? ItemPersistenceDataFile { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(ItemPersistence)}: {ItemPersistence}, {nameof(ItemPersistenceDataFile)}: {ItemPersistenceDataFile}";
}
