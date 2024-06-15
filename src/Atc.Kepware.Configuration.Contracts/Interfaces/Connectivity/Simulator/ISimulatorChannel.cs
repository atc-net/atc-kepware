namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.Simulator;

public interface ISimulatorChannel : IChannelBase
{
    bool ItemPersistence { get; set; }

    string ItemPersistenceDataFile { get; set; }
}