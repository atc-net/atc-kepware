// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Select the number of bytes of register data that can be requested at one time.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/SattBus%20Ethernet/devices
/// Section: sattbus_ethernet.DEVICE_REGISTER_BLOCK_SIZE
/// </remarks>
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "Values match Kepware API.")]
public enum SattBusEthernetRegisterBlockSizeType
{
    Bytes20 = 20,
    Bytes32 = 32,
    Bytes64 = 64,
    Bytes128 = 128,
    Bytes255 = 255,
    Bytes510 = 510,
}