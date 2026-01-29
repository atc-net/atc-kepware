namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.OmronNjEthernet;

/// <summary>
/// Omron NJ Ethernet inactivity watchdog timeout in seconds.
/// </summary>
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "Values match Kepware API.")]
[SuppressMessage("Design", "CA1027:Mark enums with FlagsAttribute", Justification = "Not a flags enum.")]
public enum OmronNjEthernetInactivityWatchdog
{
    [Description("8")]
    Seconds8 = 8,

    [Description("16")]
    Seconds16 = 16,

    [Description("32")]
    Seconds32 = 32,

    [Description("64")]
    Seconds64 = 64,

    [Description("128")]
    Seconds128 = 128,
}