// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// The specific type of device associated with this ID.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Modbus%20TCP~IP%20Ethernet/Devices
/// Section: servermain.DEVICE_MODEL
/// </remarks>
public enum ModbusDeviceModelType
{
    Modbus = 0,
    Mailbox = 1,
    Instromet = 2,
    RoxarRfm = 3,
    FluentaFgm = 4,
    Applicom = 5,
    Ceg = 6,
}
