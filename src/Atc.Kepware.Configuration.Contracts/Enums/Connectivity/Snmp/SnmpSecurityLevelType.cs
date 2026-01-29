namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.Snmp;

/// <summary>
/// SNMP v3 security level type.
/// </summary>
/// <remarks>
/// Maps to Kepware property: snmp.DEVICE_SECURITY_LEVEL.
/// </remarks>
public enum SnmpSecurityLevelType
{
    /// <summary>
    /// No authentication, no privacy.
    /// </summary>
    NoAuthNoPriv = 0,

    /// <summary>
    /// Authentication, no privacy.
    /// </summary>
    AuthNoPriv = 1,

    /// <summary>
    /// Authentication and privacy.
    /// </summary>
    AuthPriv = 2,
}