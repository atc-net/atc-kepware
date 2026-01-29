namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaGxEthernet;

/// <summary>
/// Yokogawa GX Ethernet device port selection.
/// </summary>
/// <remarks>
/// This driver only uses the Ethernet Exclusive port (TCP port 34434).
/// </remarks>
public enum YokogawaGxEthernetPort
{
    /// <summary>
    /// Ethernet (TCP port 34434).
    /// </summary>
    [Description("Ethernet")]
    Ethernet = 0,
}