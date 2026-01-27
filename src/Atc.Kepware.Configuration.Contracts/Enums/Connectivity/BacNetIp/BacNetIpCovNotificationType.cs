namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.BacNetIp;

/// <summary>
/// Specifies the COV notification type for BACnet/IP channels.
/// </summary>
public enum BacNetIpCovNotificationType
{
    /// <summary>
    /// Require NPDU source address in COV notifications.
    /// </summary>
    RequireNpdu = 0,

    /// <summary>
    /// Allow empty NPDU source address in COV notifications.
    /// </summary>
    AllowEmptyNpdu = 1,
}
