// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Specifies the IP protocol for MMIO communications.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Opto%2022%20Ethernet/devices
/// Section: opto22_ethernet.DEVICE_IO_UNIT_PROTOCOL
/// </remarks>
public enum Opto22EthernetIoUnitProtocolType
{
    Udp = 0,
    TcpIp = 1,
}