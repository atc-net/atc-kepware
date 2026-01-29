// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// TCP/IP or UDP communications for the terminal server for Allen-Bradley Bulletin 900.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Allen-Bradley%20Bulletin%20900/Devices
/// Section: servermain.DEVICE_ETHERNET_COMMUNICATIONS_PROTOCOL
/// </remarks>
public enum Bulletin900EthernetProtocolType
{
    Udp = 0,
    TcpIp = 1,
}