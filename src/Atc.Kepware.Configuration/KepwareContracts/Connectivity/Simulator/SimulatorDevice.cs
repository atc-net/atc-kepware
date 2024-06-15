namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.Simulator;

internal class SimulatorDevice : DeviceBase, ISimulatorDevice
{
    public SimulatorDevice()
    {
        // The driver does not actually support this property, simulating a simulator makes no sense.
        Simulated = true;
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public SimulatorDeviceModel? Model { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_ID_DECIMAL")]
    public int Id { get; set; } = 1;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_ID_FORMAT")]
    public SimulatorDeviceIdFormat IdFormat { get; set; } = SimulatorDeviceIdFormat.Decimal;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(Id)}: {Id}, {nameof(IdFormat)}: {IdFormat}";
}