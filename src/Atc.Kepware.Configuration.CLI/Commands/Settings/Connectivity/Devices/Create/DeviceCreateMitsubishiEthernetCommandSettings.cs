namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Devices.Create;

public class DeviceCreateMitsubishiEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICE-ID>")]
    [Description("Device IP address with PC number (format: IP:PCNumber, e.g., 192.168.1.1:0)")]
    public string DeviceId { get; init; } = "255.255.255.255:0";

    [CommandOption("--model [MODEL]")]
    [Description("Device model (ASeries, QSeries, FX3U, QnASeries, LSeries, IqFSeries, IqRSeries)")]
    public FlagValue<MitsubishiEthernetDeviceModelType>? Model { get; init; } = new();

    [CommandOption("--first-word-low")]
    [Description("First word is low for 32-bit values")]
    [DefaultValue(true)]
    public bool FirstWordLow { get; init; }

    [CommandOption("--ip-protocol [IP-PROTOCOL]")]
    [Description("IP protocol type (Udp, TcpIp)")]
    public FlagValue<MitsubishiEthernetIpProtocolType>? IpProtocol { get; init; } = new();

    [CommandOption("--port")]
    [Description("Port number (0-65535)")]
    [DefaultValue(5000)]
    public int PortNumber { get; init; }

    [CommandOption("--source-port")]
    [Description("Source port number for FX3U with UDP (0-65535)")]
    [DefaultValue(0)]
    public int SourcePortNumber { get; init; }

    [CommandOption("--cpu [CPU]")]
    [Description("Target CPU for Q/QnA/L/iQ-F/iQ-R series")]
    public FlagValue<MitsubishiEthernetCpuType>? Cpu { get; init; } = new();

    [CommandOption("--read-bit-memory")]
    [Description("Block size in word units for bit memory reads (1-127)")]
    [DefaultValue(127)]
    public int ReadBitMemory { get; init; }

    [CommandOption("--read-word-memory")]
    [Description("Block size in words for word memory reads (1-253)")]
    [DefaultValue(253)]
    public int ReadWordMemory { get; init; }

    [CommandOption("--write-bit-size")]
    [Description("Max bits per write request (1-80)")]
    [DefaultValue(80)]
    public int WriteBitSize { get; init; }

    [CommandOption("--write-word-size")]
    [Description("Max words per write request (1-40)")]
    [DefaultValue(40)]
    public int WriteWordSize { get; init; }

    [CommandOption("--write-full-string-length")]
    [Description("Pad remaining bytes after string with NULL")]
    [DefaultValue(false)]
    public bool WriteFullStringLength { get; init; }

    [CommandOption("--time-sync-method [TIME-SYNC-METHOD]")]
    [Description("Time sync method for Q/QnA/L/iQ-F/iQ-R (Disabled, Absolute, Interval)")]
    public FlagValue<MitsubishiEthernetTimeSyncMethodType>? TimeSyncMethod { get; init; } = new();

    [CommandOption("--sync-interval")]
    [Description("Sync interval in minutes when using Interval method (5-1440)")]
    [DefaultValue(5)]
    public int SyncIntervalMinutes { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (string.IsNullOrEmpty(DeviceId))
        {
            return ValidationResult.Error("--device-id is required.");
        }

        if (PortNumber < 0 || PortNumber > 65535)
        {
            return ValidationResult.Error("--port must be between 0 and 65535.");
        }

        if (SourcePortNumber < 0 || SourcePortNumber > 65535)
        {
            return ValidationResult.Error("--source-port must be between 0 and 65535.");
        }

        if (ReadBitMemory < 1 || ReadBitMemory > 127)
        {
            return ValidationResult.Error("--read-bit-memory must be between 1 and 127.");
        }

        if (ReadWordMemory < 1 || ReadWordMemory > 253)
        {
            return ValidationResult.Error("--read-word-memory must be between 1 and 253.");
        }

        if (WriteBitSize < 1 || WriteBitSize > 80)
        {
            return ValidationResult.Error("--write-bit-size must be between 1 and 80.");
        }

        if (WriteWordSize < 1 || WriteWordSize > 40)
        {
            return ValidationResult.Error("--write-word-size must be between 1 and 40.");
        }

        if (SyncIntervalMinutes < 5 || SyncIntervalMinutes > 1440)
        {
            return ValidationResult.Error("--sync-interval must be between 5 and 1440.");
        }

        return ValidationResult.Success();
    }
}