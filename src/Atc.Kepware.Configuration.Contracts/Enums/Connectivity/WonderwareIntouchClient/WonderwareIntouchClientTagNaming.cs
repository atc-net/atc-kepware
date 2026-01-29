namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.WonderwareIntouchClient;

/// <summary>
/// Specifies the tag naming option for Wonderware InTouch Client devices.
/// </summary>
public enum WonderwareIntouchClientTagNaming
{
    /// <summary>
    /// Legacy naming enforces stricter naming requirements of previous versions.
    /// </summary>
    Legacy = 0,

    /// <summary>
    /// Enhanced naming has fewer constraints and is consistent with current OPC server naming requirements.
    /// </summary>
    Enhanced = 1,
}