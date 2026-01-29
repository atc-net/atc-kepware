namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.Snmp;

/// <summary>
/// SNMP community type.
/// </summary>
/// <remarks>
/// Maps to Kepware property: snmp.DEVICE_COMMUNITY.
/// </remarks>
public enum SnmpCommunityType
{
    /// <summary>
    /// Public community.
    /// </summary>
    Public = 0,

    /// <summary>
    /// Private community.
    /// </summary>
    Private = 1,

    /// <summary>
    /// Custom community.
    /// </summary>
    Custom = 2,
}
