namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.Codesys;

/// <summary>
/// Represents the protocol types for CODESYS V2.3 devices.
/// </summary>
public enum CodesysDeviceProtocolType
{
    /// <summary>
    /// TCP/IP (Level 2).
    /// </summary>
    [Description("TCP/IP (Level 2)")]
    TcpIpLevel2 = 0,

    /// <summary>
    /// TCP/IP (Level 2 Route).
    /// </summary>
    [Description("TCP/IP (Level 2 Route)")]
    TcpIpLevel2Route = 1,

    /// <summary>
    /// TCP/IP (Level 4).
    /// </summary>
    [Description("TCP/IP (Level 4)")]
    TcpIpLevel4 = 2,
}
