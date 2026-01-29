namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.Snmp;

/// <summary>
/// SNMP v3 authentication style type.
/// </summary>
/// <remarks>
/// Maps to Kepware property: snmp.DEVICE_AUTHENTICATION_STYLE.
/// </remarks>
[SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "OK - SNMP naming convention.")]
public enum SnmpAuthenticationProtocolType
{
    /// <summary>
    /// HMAC-MD5 authentication.
    /// </summary>
    HmacMd5 = 0,

    /// <summary>
    /// HMAC-SHA1 authentication.
    /// </summary>
    HmacSha1 = 1,
}
