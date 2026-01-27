namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.MitsubishiEthernet;

/// <summary>
/// Specifies the time synchronization method for Mitsubishi Ethernet devices.
/// </summary>
public enum MitsubishiEthernetTimeSyncMethodType
{
    /// <summary>
    /// Time synchronization disabled.
    /// </summary>
    Disabled = 0,

    /// <summary>
    /// Absolute time synchronization (at a specific time each day).
    /// </summary>
    Absolute = 1,

    /// <summary>
    /// Interval-based time synchronization.
    /// </summary>
    Interval = 2,
}
