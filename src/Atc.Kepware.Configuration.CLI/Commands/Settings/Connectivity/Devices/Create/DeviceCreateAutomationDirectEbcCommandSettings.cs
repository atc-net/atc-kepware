namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Devices.Create;

public class DeviceCreateAutomationDirectEbcCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICE-ID>")]
    [Description("Device ID (IP address format, e.g., 192.168.1.1)")]
    public string DeviceId { get; init; } = string.Empty;

    [CommandOption("--model")]
    [Description("Device model (H2, H4, TerminatorIO, Gs1Drive, Gs2Drive, DurapulseGs3Drive)")]
    [DefaultValue(AutomationDirectEbcDeviceModel.H2)]
    public AutomationDirectEbcDeviceModel Model { get; init; } = AutomationDirectEbcDeviceModel.H2;

    [CommandOption("--port")]
    [Description("Communication port number (0-65535)")]
    [DefaultValue(28784)]
    public int Port { get; init; } = 28784;

    [CommandOption("--use-link-watchdog")]
    [Description("Enable link watchdog (for non-GS models only)")]
    [DefaultValue(false)]
    public bool UseLinkWatchdog { get; init; }

    [CommandOption("--watchdog-timeout-ms")]
    [Description("Watchdog timeout in milliseconds (60-32767)")]
    [DefaultValue(60)]
    public int WatchdogTimeoutMs { get; init; } = 60;

    [CommandOption("--auto-tag-generation-port")]
    [Description("Auto tag generation port (for GS models only, 0-65535)")]
    [DefaultValue(28784)]
    public int AutoTagGenerationPort { get; init; } = 28784;

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

        if (Port < 0 || Port > 65535)
        {
            return ValidationResult.Error("--port must be between 0 and 65535.");
        }

        if (WatchdogTimeoutMs < 60 || WatchdogTimeoutMs > 32767)
        {
            return ValidationResult.Error("--watchdog-timeout-ms must be between 60 and 32767.");
        }

        if (AutoTagGenerationPort < 0 || AutoTagGenerationPort > 65535)
        {
            return ValidationResult.Error("--auto-tag-generation-port must be between 0 and 65535.");
        }

        return ValidationResult.Success();
    }
}