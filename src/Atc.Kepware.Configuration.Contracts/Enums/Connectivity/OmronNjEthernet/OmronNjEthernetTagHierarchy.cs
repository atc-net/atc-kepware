namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.OmronNjEthernet;

/// <summary>
/// Omron NJ Ethernet tag hierarchy display mode.
/// </summary>
public enum OmronNjEthernetTagHierarchy
{
    /// <summary>
    /// Collapsed based on the tag's address.
    /// </summary>
    [Description("Condensed")]
    Condensed = 0,

    /// <summary>
    /// Open to show logical groupings for structures, unions, and arrays.
    /// </summary>
    [Description("Expanded")]
    Expanded = 1,
}
