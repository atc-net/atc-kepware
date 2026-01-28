namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.HoneywellUdcEthernet;

/// <summary>
/// Honeywell UDC Ethernet device ID format types.
/// </summary>
[SuppressMessage("Naming", "CA1720:Identifier contains type name", Justification = "Matches Kepware API naming convention.")]
public enum HoneywellUdcEthernetDeviceIdFormatType
{
    /// <summary>
    /// Octal format.
    /// </summary>
    Octal = 0,

    /// <summary>
    /// Decimal format.
    /// </summary>
    Decimal = 1,

    /// <summary>
    /// Hexadecimal format.
    /// </summary>
    Hex = 2,
}
