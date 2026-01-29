namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaDxpEthernet;

/// <summary>
/// Yokogawa DXP Ethernet device port selection.
/// </summary>
/// <remarks>
/// This driver only uses the Ethernet Exclusive port (TCP port 34260).
/// </remarks>
public enum YokogawaDxpEthernetPort
{
    /// <summary>
    /// Ethernet (TCP port 34260).
    /// </summary>
    [Description("Ethernet")]
    Ethernet = 0,
}