namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Simulator;

public sealed class SimulatorDevice : DeviceBase, ISimulatorDevice
{
    public SimulatorDevice()
    {
        // The driver does not actually support this property, simulating a simulator makes no sense.
        Simulated = true;
    }

    public SimulatorDeviceModel? Model { get; set; }

    public int Id { get; set; } = 1;

    public SimulatorDeviceIdFormat IdFormat { get; set; } = SimulatorDeviceIdFormat.Decimal;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(Id)}: {Id}, {nameof(IdFormat)}: {IdFormat}";
}