// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Maximum length PDU, in bytes, that the simulated device will support.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Siemens%20TCP/IP%20Server%20Ethernet/Devices
/// Section: siemens_tcpip_unsolicited_ethernet.DEVICE_MAX_PDU
/// </remarks>
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "Values match Kepware API.")]
public enum SiemensTcpIpServerMaxPduSize
{
    Pdu240 = 240,
    Pdu480 = 480,
    Pdu960 = 960,
}