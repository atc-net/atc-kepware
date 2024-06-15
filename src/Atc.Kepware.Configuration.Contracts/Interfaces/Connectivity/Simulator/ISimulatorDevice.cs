namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.Simulator;

public interface ISimulatorDevice : IDeviceBase
{
    SimulatorDeviceModel? Model { get; set; }

    int Id { get; set; }

    SimulatorDeviceIdFormat IdFormat { get; set; }
}