namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Simulator;

public sealed class SimulatorChannel : ChannelBase, ISimulatorChannel
{
    public bool ItemPersistence { get; set; }

    public string ItemPersistenceDataFile { get; set; } = string.Empty;

    public override string ToString()
        => $"{base.ToString()}, {nameof(ItemPersistence)}: {ItemPersistence}, {nameof(ItemPersistenceDataFile)}: {ItemPersistenceDataFile}";
}