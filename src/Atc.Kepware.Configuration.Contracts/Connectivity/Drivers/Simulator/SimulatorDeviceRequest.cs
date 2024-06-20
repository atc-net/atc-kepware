namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Simulator;

public sealed class SimulatorDeviceRequest : DeviceRequestBase, ISimulatorDeviceRequest
{
    public SimulatorDeviceRequest()
        : base(DriverType.Simulator)
    {
        // The driver does not actually support this property, simulating a simulator makes no sense.
        Simulated = true;
    }

    /// <inheritdoc />
    public SimulatorDeviceModel Model { get; set; } = SimulatorDeviceModel.SixteenBit;

    /// <inheritdoc />
    [Range(1, 999)]
    public int Id { get; set; } = 1;

    /// <inheritdoc />
    public SimulatorDeviceIdFormat IdFormat { get; set; } = SimulatorDeviceIdFormat.Decimal;

    // <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(Id)}: {Id}, {nameof(IdFormat)}: {IdFormat}";
}