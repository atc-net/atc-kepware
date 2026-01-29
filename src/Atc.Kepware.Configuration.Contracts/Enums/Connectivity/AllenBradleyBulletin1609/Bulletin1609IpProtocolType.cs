// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// The Ethernet protocol used by the device for Allen-Bradley Bulletin 1609.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Allen-Bradley%20Bulletin%201609/Devices
/// Section: a-b_bulletin_1609.DEVICE_IP_PROTOCOL
/// </remarks>
public enum Bulletin1609IpProtocolType
{
    Tcp = 0,
    Udp = 1,
}