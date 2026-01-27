// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Specifies the amount of time, in seconds, a connection can remain idle before being closed by the controller.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Allen-Bradley%20Micro800%20Ethernet/Devices
/// Section: allenbradley_micro800_ethernet.DEVICE_INACTIVITY_WATCHDOG_SECONDS
/// </remarks>
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "Values match Kepware API.")]
[SuppressMessage("Design", "CA1027:Mark enums with FlagsAttribute", Justification = "Not a flags enum.")]
public enum Micro800InactivityWatchdogType
{
    Seconds8 = 8,
    Seconds16 = 16,
    Seconds32 = 32,
    Seconds64 = 64,
    Seconds128 = 128,
}
