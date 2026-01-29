namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.Snmp;

/// <summary>
/// SNMP v3 encryption style type.
/// </summary>
/// <remarks>
/// Maps to Kepware property: snmp.DEVICE_ENCRYPTION_STYLE.
/// </remarks>
[SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "OK - SNMP naming convention.")]
public enum SnmpPrivacyProtocolType
{
    /// <summary>
    /// DES encryption.
    /// </summary>
    Des = 0,

    /// <summary>
    /// AES 128-bit encryption.
    /// </summary>
    Aes128 = 1,

    /// <summary>
    /// AES 192-bit encryption.
    /// </summary>
    Aes192 = 2,

    /// <summary>
    /// AES 256-bit encryption.
    /// </summary>
    Aes256 = 3,
}