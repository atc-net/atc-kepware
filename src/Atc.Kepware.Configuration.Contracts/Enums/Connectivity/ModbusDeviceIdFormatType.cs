// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// The format of the device ID.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Modbus%20TCP~IP%20Ethernet/Devices
/// Section: servermain.DEVICE_ID_FORMAT
/// </remarks>
[SuppressMessage("Naming", "CA1720:Identifier contains type name", Justification = "Matches Kepware API naming convention.")]
public enum ModbusDeviceIdFormatType
{
    Octal = 0,
    Decimal = 1,
    Hex = 2,
}
