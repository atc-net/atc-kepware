// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Indicates whether the driver should use User Datagram Protocol (UDP) or
/// Transfer Control Protocol (TCP). The Modbus client and server settings must match.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Modbus%20TCP~IP%20Ethernet/Devices
/// Section: modbus_ethernet.DEVICE_ETHERNET_IP_PROTOCOL
/// </remarks>
public enum ModbusDeviceIpProtocolType
{
    Udp = 0,
    TcpIp = 1,
}