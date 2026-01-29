namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaDxEthernet;

/// <summary>
/// Yokogawa DX Ethernet device port selection.
/// </summary>
/// <remarks>
/// This driver only uses the Ethernet Exclusive port (TCP port 34260).
/// </remarks>
public enum YokogawaDxEthernetPort
{
    /// <summary>
    /// Ethernet (TCP port 34260).
    /// </summary>
    [Description("Ethernet")]
    Ethernet = 0,
}
