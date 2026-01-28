namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.CutlerHammerElcEthernet;

/// <summary>
/// Device ID format types for the Cutler-Hammer ELC Ethernet driver.
/// </summary>
[SuppressMessage("Naming", "CA1720:Identifier contains type name", Justification = "Matches Kepware API naming convention.")]
public enum CutlerHammerElcEthernetDeviceIdFormatType
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
