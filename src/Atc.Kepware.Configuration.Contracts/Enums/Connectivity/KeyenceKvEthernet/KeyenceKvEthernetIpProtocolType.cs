// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Indicates the correct protocol to use when communicating with the device.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Keyence%20KV%20Ethernet/devices
/// Section: keyence_kv_ethernet.DEVICE_IP_PROTOCOL
/// </remarks>
public enum KeyenceKvEthernetIpProtocolType
{
    TcpIp = 0,
    Udp = 1,
}