namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MemoryBased;

public sealed class MemoryBasedDeviceRequest : DeviceRequestBase, IMemoryBasedDeviceRequest
{
    public MemoryBasedDeviceRequest()
        : base(DriverType.MemoryBased)
    {
    }

    /// <inheritdoc />
    public MemoryBasedDeviceModel Model { get; set; } = MemoryBasedDeviceModel.NotApplicable;

    /// <inheritdoc />
    [Range(1, 999)]
    public int Id { get; set; } = 1;

    /// <inheritdoc />
    public MemoryBasedDeviceIdFormat IdFormat { get; set; } = MemoryBasedDeviceIdFormat.Decimal;

    // <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(Id)}: {Id}, {nameof(IdFormat)}: {IdFormat}";
}
