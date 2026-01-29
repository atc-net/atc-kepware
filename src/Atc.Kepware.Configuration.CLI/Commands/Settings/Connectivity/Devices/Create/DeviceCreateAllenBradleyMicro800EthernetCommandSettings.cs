namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Devices.Create;

public class DeviceCreateAllenBradleyMicro800EthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id")]
    [Description("Device ID (IP address or hostname)")]
    [DefaultValue("127.0.0.1")]
    public string DeviceId { get; init; } = "127.0.0.1";

    [CommandOption("--port")]
    [Description("Port number for the target device (0-65535)")]
    [DefaultValue(44818)]
    public int Port { get; init; }

    [CommandOption("--inactivity-watchdog")]
    [Description("Inactivity watchdog timeout in seconds")]
    [DefaultValue(Micro800InactivityWatchdogType.Seconds32)]
    public Micro800InactivityWatchdogType InactivityWatchdog { get; init; }

    [CommandOption("--default-data-type")]
    [Description("Default data type for tags")]
    [DefaultValue(Micro800DefaultDataType.Float)]
    public Micro800DefaultDataType DefaultDataType { get; init; }

    [CommandOption("--array-block-size")]
    [Description("Maximum number of array elements to read in a single transaction (30-3840)")]
    [DefaultValue(120)]
    public int ArrayBlockSize { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (Port < 0 || Port > 65535)
        {
            return ValidationResult.Error("--port must be between 0 and 65535.");
        }

        if (ArrayBlockSize < 30 || ArrayBlockSize > 3840)
        {
            return ValidationResult.Error("--array-block-size must be between 30 and 3840.");
        }

        return ValidationResult.Success();
    }
}