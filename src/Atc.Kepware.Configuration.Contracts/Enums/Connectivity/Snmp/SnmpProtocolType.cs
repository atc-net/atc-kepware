namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.Snmp;

/// <summary>
/// SNMP IP protocol type.
/// </summary>
/// <remarks>
/// Maps to Kepware property: snmp.DEVICE_COMMUNICATIONS_PROTOCOL.
/// </remarks>
public enum SnmpProtocolType
{
    /// <summary>
    /// TCP protocol.
    /// </summary>
    Tcp = 0,

    /// <summary>
    /// UDP protocol.
    /// </summary>
    Udp = 1,
}