namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaCxEthernet;

/// <summary>
/// Yokogawa CX Ethernet device port selection.
/// </summary>
/// <remarks>
/// This driver only uses the Ethernet Exclusive port (TCP port 34150).
/// </remarks>
public enum YokogawaCxEthernetPort
{
    /// <summary>
    /// Ethernet (TCP port 34150).
    /// </summary>
    [Description("Ethernet")]
    Ethernet = 0,
}