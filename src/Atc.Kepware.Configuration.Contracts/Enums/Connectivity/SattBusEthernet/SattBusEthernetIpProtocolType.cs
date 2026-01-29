// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Indicates the correct protocol to use when communicating with the device.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/SattBus%20Ethernet/devices
/// Section: sattbus_ethernet.DEVICE_IP_PROTOCOL
/// </remarks>
public enum SattBusEthernetIpProtocolType
{
    Udp = 0,
    TcpIp = 1,
}