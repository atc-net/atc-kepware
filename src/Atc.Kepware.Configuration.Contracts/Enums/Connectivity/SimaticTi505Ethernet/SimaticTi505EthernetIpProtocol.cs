namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.SimaticTi505Ethernet;

/// <summary>
/// Simatic/TI 505 Ethernet IP protocol.
/// </summary>
public enum SimaticTi505EthernetIpProtocol
{
    /// <summary>
    /// User Datagram Protocol.
    /// </summary>
    [Description("UDP")]
    Udp = 0,

    /// <summary>
    /// Transfer Control Protocol.
    /// </summary>
    [Description("TCP")]
    Tcp = 1,
}