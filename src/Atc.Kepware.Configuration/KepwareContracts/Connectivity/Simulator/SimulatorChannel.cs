namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.Simulator;

/// <summary>
/// Channel properties for the Simulator driver.
/// </summary>
internal class SimulatorChannel : ChannelBase, ISimulatorChannel
{
    /// <inheritdoc />
    [JsonPropertyName("simulator.CHANNEL_ITEM_PERSISTENCE")]
    public bool ItemPersistence { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("simulator.CHANNEL_ITEM_PERSISTENCE_DATA_FILE")]
    public string ItemPersistenceDataFile { get; set; } = string.Empty;

    public override string ToString()
        => $"{base.ToString()}, {nameof(ItemPersistence)}: {ItemPersistence}, {nameof(ItemPersistenceDataFile)}: {ItemPersistenceDataFile}";
}