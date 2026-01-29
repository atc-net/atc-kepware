namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateAllenBradleyControlLogixEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICEID>")]
    [Description("The device ID in format: <IP or Hostname>,1,[<Optional Routing Path>],<CPU Slot> (e.g., '192.168.1.1,1,0')")]
    public string DeviceId { get; init; } = string.Empty;

    [CommandOption("--model")]
    [ControlLogixDeviceModelTypeDescription]
    public FlagValue<ControlLogixDeviceModelType>? Model { get; init; }

    [CommandOption("--port")]
    [Description("Specify the EtherNet/IP port on the target device (default: 44818)")]
    public int Port { get; init; } = 44818;

    [CommandOption("--connection-size")]
    [Description("Specify the maximum number of bytes available on the CIP connection (500-4000, default: 500)")]
    public int ConnectionSizeBytes { get; init; } = 500;

    [CommandOption("--inactivity-watchdog")]
    [ControlLogixInactivityWatchdogTypeDescription]
    public FlagValue<ControlLogixInactivityWatchdogType>? InactivityWatchdog { get; init; }

    [CommandOption("--array-block-size")]
    [ControlLogixArrayBlockSizeTypeDescription]
    public FlagValue<ControlLogixArrayBlockSizeType>? ArrayBlockSize { get; init; }

    [CommandOption("--protocol-mode")]
    [ControlLogixProtocolModeTypeDescription]
    public FlagValue<ControlLogixProtocolModeType>? ProtocolMode { get; init; }

    [CommandOption("--sync-online-edits")]
    [Description("Synchronize with the controller after an online edit or download (default: true)")]
    public bool SynchronizeAfterOnlineEdits { get; init; } = true;

    [CommandOption("--sync-offline-edits")]
    [Description("Synchronize with the controller after an offline edit or download (default: true)")]
    public bool SynchronizeAfterOfflineEdits { get; init; } = true;
}