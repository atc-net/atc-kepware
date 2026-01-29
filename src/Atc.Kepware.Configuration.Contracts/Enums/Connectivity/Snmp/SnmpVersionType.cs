namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.Snmp;

/// <summary>
/// SNMP protocol version type.
/// </summary>
/// <remarks>
/// Maps to Kepware property: snmp.DEVICE_SNMP_VERSION.
/// </remarks>
[SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "OK - SNMP version naming convention.")]
public enum SnmpVersionType
{
    /// <summary>
    /// SNMP version 1.
    /// </summary>
    V1 = 0,

    /// <summary>
    /// SNMP version 2c.
    /// </summary>
    V2c = 1,

    /// <summary>
    /// SNMP version 3.
    /// </summary>
    V3 = 3,
}
