// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Select the access rights clients have with respect to the memory map for Mailbox devices.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Modbus%20TCP~IP%20Ethernet/Devices
/// Section: modbus_ethernet.DEVICE_MAILBOX_CLIENT_PRIVILEGES
/// Only applicable when Device Model is Mailbox.
/// </remarks>
public enum ModbusMailboxClientPrivilegesType
{
    MemoryMapReadOnly = 0,
    DeviceWriteMemoryMapRead = 1,
    MemoryMapReadWrite = 2,
}
