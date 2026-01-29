namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MemoryBased;

internal class MemoryBasedDeviceRequest : DeviceRequestBase, IMemoryBasedDeviceRequest
{
    public MemoryBasedDeviceRequest()
        : base(DriverType.MemoryBased)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public MemoryBasedDeviceModel Model { get; set; } = MemoryBasedDeviceModel.NotApplicable;

    /// <inheritdoc />
    [Range(1, 999)]
    [JsonIgnore]
    public int Id { get; set; } = 1;

    [JsonPropertyName("servermain.DEVICE_ID_FORMAT")]
    public MemoryBasedDeviceIdFormat IdFormat { get; set; } = MemoryBasedDeviceIdFormat.Decimal;

    [JsonPropertyName("servermain.DEVICE_ID_OCTAL")]
    public int OctalId => Id;

    [JsonPropertyName("servermain.DEVICE_ID_DECIMAL")]
    public int DecimalId => Id;

    [JsonPropertyName("servermain.DEVICE_ID_HEXADECIMAL")]
    public int HexadecimalId => Id;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(Id)}: {Id}, {nameof(IdFormat)}: {IdFormat}";
}