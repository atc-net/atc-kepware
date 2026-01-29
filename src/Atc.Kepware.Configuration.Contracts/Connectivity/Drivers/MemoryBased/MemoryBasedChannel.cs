namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MemoryBased;

public sealed class MemoryBasedChannel : ChannelBase, IMemoryBasedChannel
{
    public bool ItemPersistence { get; set; }

    public string ItemPersistenceDataFile { get; set; } = string.Empty;

    public override string ToString()
        => $"{base.ToString()}, {nameof(ItemPersistence)}: {ItemPersistence}, {nameof(ItemPersistenceDataFile)}: {ItemPersistenceDataFile}";
}
