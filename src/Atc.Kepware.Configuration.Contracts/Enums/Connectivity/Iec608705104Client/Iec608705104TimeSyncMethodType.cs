namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.Iec608705104Client;

/// <summary>
/// Specifies how the device and server compare and match time clock settings.
/// </summary>
public enum Iec608705104TimeSyncMethodType
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

    /// <summary>
    /// Time synchronization occurs on poll.
    /// </summary>
    OnPoll = 3,
}
