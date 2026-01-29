namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.SiemensTcpIpEthernet;

/// <summary>
/// Siemens TCP/IP Ethernet byte order types.
/// </summary>
public enum SiemensTcpIpEthernetByteOrderType
{
    /// <summary>
    /// Big Endian (Motorola) - default for Siemens S7 controllers.
    /// </summary>
    BigEndian = 0,

    /// <summary>
    /// Little Endian (Intel).
    /// </summary>
    LittleEndian = 1,
}