// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// The Ethernet protocol for the channel to use when listening for unsolicited requests.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Modbus%20TCP~IP%20Ethernet/Channels
/// Section: modbus_ethernet.CHANNEL_ETHERNET_PROTOCOL
/// </remarks>
public enum ModbusChannelIpProtocolType
{
    TcpIp = 0,
    Udp = 1,
}
