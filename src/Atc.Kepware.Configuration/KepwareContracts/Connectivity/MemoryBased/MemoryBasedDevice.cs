namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MemoryBased;

internal class MemoryBasedDevice : DeviceBase, IMemoryBasedDevice
{
    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public MemoryBasedDeviceModel? Model { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_ID_DECIMAL")]
    public int Id { get; set; } = 1;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_ID_FORMAT")]
    public MemoryBasedDeviceIdFormat IdFormat { get; set; } = MemoryBasedDeviceIdFormat.Decimal;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(Id)}: {Id}, {nameof(IdFormat)}: {IdFormat}";
}