namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.WonderwareIntouchClient;

/// <summary>
/// Specifies the mode of data access for Wonderware InTouch Client devices.
/// </summary>
public enum WonderwareIntouchClientMode
{
    /// <summary>
    /// The driver polls InTouch for data.
    /// </summary>
    DriverPollsInTouch = 0,

    /// <summary>
    /// InTouch notifies the driver of data changes.
    /// </summary>
    InTouchNotifiesDriver = 1,

    /// <summary>
    /// Combination of polling and notification modes.
    /// </summary>
    Combination = 2,
}
