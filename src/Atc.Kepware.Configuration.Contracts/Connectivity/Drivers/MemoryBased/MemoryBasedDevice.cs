namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MemoryBased;

public sealed class MemoryBasedDevice : DeviceBase, IMemoryBasedDevice
{
    public MemoryBasedDeviceModel? Model { get; set; }

    public int Id { get; set; } = 1;

    public MemoryBasedDeviceIdFormat IdFormat { get; set; } = MemoryBasedDeviceIdFormat.Decimal;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(Id)}: {Id}, {nameof(IdFormat)}: {IdFormat}";
}
