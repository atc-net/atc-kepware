namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateBristolBsapIpCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--rtu-ip-address <RTU-IP-ADDRESS>")]
    [Description("RTU IP address")]
    public string RtuIpAddress { get; init; } = string.Empty;

    [CommandOption("--model [MODEL]")]
    [Description("Device model (Dpc33Xx, ControlWave)")]
    public FlagValue<BristolBsapIpDeviceModelType>? Model { get; init; } = new();

    [CommandOption("--rtu-global-address")]
    [Description("RTU Global Address in hexadecimal (0-65535). Enter 0 for local devices.")]
    [DefaultValue(0)]
    public int RtuGlobalAddress { get; init; }

    [CommandOption("--rtu-udp-port")]
    [Description("RTU UDP port number (1-65535)")]
    [DefaultValue(1234)]
    public int RtuUdpPort { get; init; }

    [CommandOption("--maximum-bytes-per-request")]
    [Description("Maximum bytes per read or write request (64-256)")]
    [DefaultValue(256)]
    public int MaximumBytesPerRequest { get; init; }

    [CommandOption("--level [LEVEL]")]
    [Description("Device level (Level1, Level2, Level3, Level4, Level5, Level6)")]
    public FlagValue<BristolBsapIpDeviceLevelType>? Level { get; init; } = new();

    [CommandOption("--request-timeout-ms")]
    [Description("Request timeout in milliseconds (100-60000)")]
    [DefaultValue(1000)]
    public int RequestTimeoutMs { get; init; }

    [CommandOption("--fail-after-successive-timeouts")]
    [Description("Number of times a request may timeout before failing (1-10)")]
    [DefaultValue(3)]
    public int FailAfterSuccessiveTimeouts { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (string.IsNullOrEmpty(RtuIpAddress))
        {
            return ValidationResult.Error("--rtu-ip-address is required.");
        }

        if (RtuGlobalAddress < 0 || RtuGlobalAddress > 65535)
        {
            return ValidationResult.Error("--rtu-global-address must be between 0 and 65535.");
        }

        if (RtuUdpPort < 1 || RtuUdpPort > 65535)
        {
            return ValidationResult.Error("--rtu-udp-port must be between 1 and 65535.");
        }

        if (MaximumBytesPerRequest < 64 || MaximumBytesPerRequest > 256)
        {
            return ValidationResult.Error("--maximum-bytes-per-request must be between 64 and 256.");
        }

        if (RequestTimeoutMs < 100 || RequestTimeoutMs > 60000)
        {
            return ValidationResult.Error("--request-timeout-ms must be between 100 and 60000.");
        }

        if (FailAfterSuccessiveTimeouts < 1 || FailAfterSuccessiveTimeouts > 10)
        {
            return ValidationResult.Error("--fail-after-successive-timeouts must be between 1 and 10.");
        }

        return ValidationResult.Success();
    }
}
