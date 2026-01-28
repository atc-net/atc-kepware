namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.BeckhoffTwinCat;

/// <summary>
/// Beckhoff TwinCAT device ID format type.
/// </summary>
[SuppressMessage("Naming", "CA1720:Identifier contains type name", Justification = "Names match Kepware API.")]
public enum BeckhoffTwinCatIdFormat
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
