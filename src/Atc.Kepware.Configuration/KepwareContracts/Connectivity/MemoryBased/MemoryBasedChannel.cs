namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MemoryBased;

/// <summary>
/// Channel properties for the Memory Based driver.
/// </summary>
internal class MemoryBasedChannel : ChannelBase, IMemoryBasedChannel
{
    /// <inheritdoc />
    [JsonPropertyName("memory_based.CHANNEL_ITEM_PERSISTENCE")]
    public bool ItemPersistence { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("memory_based.CHANNEL_ITEM_PERSISTENCE_DATA_FILE")]
    public string ItemPersistenceDataFile { get; set; } = string.Empty;

    public override string ToString()
        => $"{base.ToString()}, {nameof(ItemPersistence)}: {ItemPersistence}, {nameof(ItemPersistenceDataFile)}: {ItemPersistenceDataFile}";
}
