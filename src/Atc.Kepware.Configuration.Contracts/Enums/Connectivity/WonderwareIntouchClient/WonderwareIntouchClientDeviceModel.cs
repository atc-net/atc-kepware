namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.WonderwareIntouchClient;

/// <summary>
/// Specifies the device model for Wonderware InTouch Client devices.
/// </summary>
public enum WonderwareIntouchClientDeviceModel
{
    /// <summary>
    /// InTouch device with read/write access.
    /// </summary>
    InTouch = 0,

    /// <summary>
    /// InTouch device with read-only access.
    /// </summary>
    InTouchReadOnly = 1,
}
