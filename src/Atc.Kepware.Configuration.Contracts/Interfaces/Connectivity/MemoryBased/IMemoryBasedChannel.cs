namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.MemoryBased;

public interface IMemoryBasedChannel : IChannelBase
{
    bool ItemPersistence { get; set; }

    string ItemPersistenceDataFile { get; set; }
}
