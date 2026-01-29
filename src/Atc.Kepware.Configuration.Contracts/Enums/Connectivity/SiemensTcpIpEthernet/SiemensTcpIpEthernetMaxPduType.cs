namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.SiemensTcpIpEthernet;

/// <summary>
/// Siemens TCP/IP Ethernet maximum PDU size types (in bytes).
/// </summary>
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "Values match Kepware API")]
public enum SiemensTcpIpEthernetMaxPduType
{
    /// <summary>
    /// 240 bytes.
    /// </summary>
    Bytes240 = 240,

    /// <summary>
    /// 480 bytes.
    /// </summary>
    Bytes480 = 480,

    /// <summary>
    /// 960 bytes (default).
    /// </summary>
    Bytes960 = 960,
}