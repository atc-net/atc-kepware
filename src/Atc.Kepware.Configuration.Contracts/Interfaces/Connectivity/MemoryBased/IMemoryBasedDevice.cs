namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.MemoryBased;

public interface IMemoryBasedDevice : IDeviceBase
{
    MemoryBasedDeviceModel? Model { get; set; }

    int Id { get; set; }

    MemoryBasedDeviceIdFormat IdFormat { get; set; }
}
