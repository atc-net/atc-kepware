namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaMwEthernet;

/// <summary>
/// Yokogawa MW Ethernet device port selection.
/// </summary>
/// <remarks>
/// This driver only uses the Ethernet port (TCP port 34318).
/// </remarks>
public enum YokogawaMwEthernetPort
{
    /// <summary>
    /// Ethernet (TCP port 34318).
    /// </summary>
    [Description("Ethernet")]
    Ethernet = 0,
}