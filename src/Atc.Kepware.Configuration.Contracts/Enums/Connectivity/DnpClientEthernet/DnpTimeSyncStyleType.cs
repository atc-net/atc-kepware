namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.DnpClientEthernet;

/// <summary>
/// Specifies the style of time synchronization the DNP client should use
/// when a synchronization request is received from the DNP server.
/// </summary>
public enum DnpTimeSyncStyleType
{
    /// <summary>
    /// Serial time synchronization.
    /// </summary>
    Serial = 0,

    /// <summary>
    /// LAN time synchronization.
    /// </summary>
    Lan = 1,
}
