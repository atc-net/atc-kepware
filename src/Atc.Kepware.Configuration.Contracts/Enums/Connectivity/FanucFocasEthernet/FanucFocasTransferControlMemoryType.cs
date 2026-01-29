namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.FanucFocasEthernet;

/// <summary>
/// Fanuc Focas Ethernet transfer control memory types for unsolicited message transfer control.
/// </summary>
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "Values represent actual memory type codes from API.")]
public enum FanucFocasTransferControlMemoryType
{
    /// <summary>
    /// R memory type (default).
    /// </summary>
    R = 5,

    /// <summary>
    /// E memory type.
    /// </summary>
    E = 12,
}