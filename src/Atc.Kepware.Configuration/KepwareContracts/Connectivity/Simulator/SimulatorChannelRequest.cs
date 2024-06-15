namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.Simulator;

/// <summary>
/// Channel properties for the Simulator driver.
/// </summary>
internal class SimulatorChannelRequest : ChannelRequestBase, ISimulatorChannelRequest
{
    public SimulatorChannelRequest()
        : base(DriverType.Simulator)
    {
    }

    [JsonPropertyName("simulator.CHANNEL_ITEM_PERSISTENCE")]
    public bool ItemPersistence { get; set; }

    [JsonPropertyName("simulator.CHANNEL_ITEM_PERSISTENCE_DATA_FILE")]
    public string? ItemPersistenceDataFile { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(ItemPersistence)}: {ItemPersistence}, {nameof(ItemPersistenceDataFile)}: {ItemPersistenceDataFile}";
}