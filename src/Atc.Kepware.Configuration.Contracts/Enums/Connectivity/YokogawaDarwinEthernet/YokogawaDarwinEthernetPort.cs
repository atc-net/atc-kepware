namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaDarwinEthernet;

/// <summary>
/// Yokogawa Darwin Ethernet device port selection.
/// </summary>
/// <remarks>
/// Ethernet Exclusive Port uses port 34150 and only supports a single connected host.
/// Ethernet Shared Port uses port 34151 and supports up to four simultaneous connections.
/// </remarks>
public enum YokogawaDarwinEthernetPort
{
    /// <summary>
    /// Ethernet Exclusive Port (TCP port 34150) - supports a single connected host.
    /// </summary>
    [Description("Ethernet Exclusive Port")]
    EthernetExclusivePort = 0,

    /// <summary>
    /// Ethernet Shared Port (TCP port 34151) - supports up to four simultaneous connections.
    /// </summary>
    [Description("Ethernet Shared Port")]
    EthernetSharedPort = 1,
}
