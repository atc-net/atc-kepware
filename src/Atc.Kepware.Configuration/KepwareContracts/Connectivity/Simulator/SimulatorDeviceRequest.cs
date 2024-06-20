namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.Simulator;

internal class SimulatorDeviceRequest : DeviceRequestBase, ISimulatorDeviceRequest
{
    public SimulatorDeviceRequest()
        : base(DriverType.Simulator)
    {
        // The driver does not actually support this property, simulating a simulator makes no sense.
        Simulated = true;
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public SimulatorDeviceModel Model { get; set; } = SimulatorDeviceModel.SixteenBit;

    /// <inheritdoc />
    [Range(1, 999)]
    [JsonIgnore]
    public int Id { get; set; } = 1;

    [JsonPropertyName("servermain.DEVICE_ID_FORMAT")]
    public SimulatorDeviceIdFormat IdFormat { get; set; } = SimulatorDeviceIdFormat.Decimal;

    [JsonPropertyName("servermain.DEVICE_ID_OCTAL")]
    public int OctalId => Id;

    [JsonPropertyName("servermain.DEVICE_ID_DECIMAL")]
    public int DecimalId => Id;

    [JsonPropertyName("servermain.DEVICE_ID_HEXADECIMAL")]
    public int HexadecimalId => Id;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(Id)}: {Id}, {nameof(IdFormat)}: {IdFormat}";
}