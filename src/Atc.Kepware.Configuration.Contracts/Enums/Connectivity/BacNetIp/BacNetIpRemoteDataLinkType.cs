namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.BacNetIp;

/// <summary>
/// Specifies the remote data link technology for BACnet/IP devices.
/// </summary>
public enum BacNetIpRemoteDataLinkType
{
    /// <summary>
    /// BACnet/IP data link.
    /// </summary>
    BacNetIp = 0,

    /// <summary>
    /// MS/TP data link.
    /// </summary>
    MsTp = 1,

    /// <summary>
    /// Point-to-Point data link.
    /// </summary>
    PointToPoint = 2,

    /// <summary>
    /// Ethernet data link.
    /// </summary>
    Ethernet = 3,

    /// <summary>
    /// ARCNET data link.
    /// </summary>
    ArcNet = 4,

    /// <summary>
    /// LonTalk data link.
    /// </summary>
    LonTalk = 5,
}
