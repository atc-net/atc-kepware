namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.DnpClientEthernet;

/// <summary>
/// Specifies if unsolicited messaging is allowed for a data class.
/// </summary>
public enum DnpUnsolicitedModeType
{
    /// <summary>
    /// Disable unsolicited messaging.
    /// </summary>
    Disable = 0,

    /// <summary>
    /// Enable unsolicited messaging.
    /// </summary>
    Enable = 1,

    /// <summary>
    /// Automatic - let the driver decide based on device behavior.
    /// </summary>
    Automatic = 2,
}
