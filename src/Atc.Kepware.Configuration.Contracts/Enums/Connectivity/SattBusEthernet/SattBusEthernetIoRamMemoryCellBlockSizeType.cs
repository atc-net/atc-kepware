// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Specify the number of bytes of I/O RAM/Memory cell data that may be requested at one time.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/SattBus%20Ethernet/devices
/// Section: sattbus_ethernet.DEVICE_IO_RAM_MEMORY_CELL_BLOCK_SIZE
/// </remarks>
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "Values match Kepware API.")]
public enum SattBusEthernetIoRamMemoryCellBlockSizeType
{
    Bytes20 = 20,
    Bytes32 = 32,
    Bytes64 = 64,
    Bytes128 = 128,
    Bytes255 = 255,
}