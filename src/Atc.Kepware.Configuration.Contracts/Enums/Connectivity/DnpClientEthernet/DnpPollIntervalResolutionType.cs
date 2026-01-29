namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.DnpClientEthernet;

/// <summary>
/// Specifies the polling interval resolution.
/// </summary>
public enum DnpPollIntervalResolutionType
{
    /// <summary>
    /// Milliseconds.
    /// </summary>
    Milliseconds = 0,

    /// <summary>
    /// Seconds.
    /// </summary>
    Seconds = 1,

    /// <summary>
    /// Minutes.
    /// </summary>
    Minutes = 2,

    /// <summary>
    /// Hours.
    /// </summary>
    Hours = 3,
}
