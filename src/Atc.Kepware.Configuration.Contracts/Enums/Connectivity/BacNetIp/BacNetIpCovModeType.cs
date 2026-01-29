namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.BacNetIp;

/// <summary>
/// Specifies the COV subscription mode for BACnet/IP devices.
/// </summary>
public enum BacNetIpCovModeType
{
    /// <summary>
    /// Use unconfirmed COV notifications.
    /// </summary>
    UseUnconfirmedCov = 0,

    /// <summary>
    /// Use confirmed COV notifications.
    /// </summary>
    UseConfirmedCov = 1,

    /// <summary>
    /// Do not use COV.
    /// </summary>
    DoNotUseCov = 2,
}
