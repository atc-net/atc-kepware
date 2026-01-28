namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.HoneywellHc900Ethernet;

/// <summary>
/// Honeywell HC900 Ethernet device ID format types.
/// </summary>
[SuppressMessage("Naming", "CA1720:Identifier contains type name", Justification = "Matches Kepware API naming convention.")]
public enum HoneywellHc900EthernetDeviceIdFormatType
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
