namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateOmronNjEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--model")]
    [Description("Device model")]
    [DefaultValue(OmronNjEthernetModel.OmronNj)]
    public OmronNjEthernetModel Model { get; init; } = OmronNjEthernetModel.OmronNj;

    [CommandOption("--port")]
    [Description("TCP/IP port number on the target device")]
    [DefaultValue(44818)]
    public int Port { get; init; } = 44818;

    [CommandOption("--connection-size")]
    [Description("Maximum number of bytes available on the CIP connection (500-1996)")]
    [DefaultValue(1996)]
    public int ConnectionSize { get; init; } = 1996;

    [CommandOption("--inactivity-watchdog")]
    [Description("Amount of time in seconds the CIP connection can be idle before being closed")]
    [DefaultValue(OmronNjEthernetInactivityWatchdog.Seconds32)]
    public OmronNjEthernetInactivityWatchdog InactivityWatchdog { get; init; } = OmronNjEthernetInactivityWatchdog.Seconds32;

    [CommandOption("--array-block-size")]
    [Description("Maximum number of array elements to be read in a single transaction")]
    [DefaultValue(OmronNjEthernetArrayBlockSize.Elements120)]
    public OmronNjEthernetArrayBlockSize ArrayBlockSize { get; init; } = OmronNjEthernetArrayBlockSize.Elements120;

    [CommandOption("--performance-statistics")]
    [Description("Track and record performance metrics")]
    [DefaultValue(false)]
    public bool PerformanceStatistics { get; init; }

    [CommandOption("--tag-hierarchy")]
    [Description("Tag hierarchy display mode")]
    [DefaultValue(OmronNjEthernetTagHierarchy.Expanded)]
    public OmronNjEthernetTagHierarchy TagHierarchy { get; init; } = OmronNjEthernetTagHierarchy.Expanded;
}
