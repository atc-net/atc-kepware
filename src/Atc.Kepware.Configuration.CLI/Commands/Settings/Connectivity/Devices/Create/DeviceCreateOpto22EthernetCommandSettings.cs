namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Devices.Create;

public class DeviceCreateOpto22EthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICE-ID>")]
    [Description("Device ID (IP Address)")]
    public string DeviceId { get; init; } = "255.255.255.255";

    [CommandOption("--model [MODEL]")]
    [Description("Device model (Opto22)")]
    public FlagValue<Opto22EthernetDeviceModelType>? Model { get; init; } = new();

    [CommandOption("--io-unit-protocol [PROTOCOL]")]
    [Description("I/O Unit IP Protocol (Udp, TcpIp)")]
    public FlagValue<Opto22EthernetIoUnitProtocolType>? IoUnitProtocol { get; init; } = new();

    [CommandOption("--io-unit-port-number")]
    [Description("I/O Unit port number for MMIO communications (1-65535)")]
    [DefaultValue(2001)]
    public int IoUnitPortNumber { get; init; }

    [CommandOption("--control-engine-port-number")]
    [Description("Control Engine port number for CONT communications (1-65535)")]
    [DefaultValue(22001)]
    public int ControlEnginePortNumber { get; init; }

    [CommandOption("--import-file")]
    [Description("Browser database file (*.bdb) for tag import")]
    public string? ImportFile { get; init; }

    [CommandOption("--connect-timeout-seconds")]
    [Description("Connection timeout in seconds (1-30)")]
    [DefaultValue(3)]
    public int ConnectTimeoutSeconds { get; init; }

    [CommandOption("--request-timeout-ms")]
    [Description("Request timeout in milliseconds (50-9999999)")]
    [DefaultValue(1000)]
    public int RequestTimeoutMs { get; init; }

    [CommandOption("--retry-attempts")]
    [Description("Number of retry attempts (1-10)")]
    [DefaultValue(3)]
    public int RetryAttempts { get; init; }

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

        if (IoUnitPortNumber < 1 || IoUnitPortNumber > 65535)
        {
            return ValidationResult.Error("--io-unit-port-number must be between 1 and 65535.");
        }

        if (ControlEnginePortNumber < 1 || ControlEnginePortNumber > 65535)
        {
            return ValidationResult.Error("--control-engine-port-number must be between 1 and 65535.");
        }

        if (ConnectTimeoutSeconds < 1 || ConnectTimeoutSeconds > 30)
        {
            return ValidationResult.Error("--connect-timeout-seconds must be between 1 and 30.");
        }

        if (RequestTimeoutMs < 50 || RequestTimeoutMs > 9999999)
        {
            return ValidationResult.Error("--request-timeout-ms must be between 50 and 9999999.");
        }

        if (RetryAttempts < 1 || RetryAttempts > 10)
        {
            return ValidationResult.Error("--retry-attempts must be between 1 and 10.");
        }

        return ValidationResult.Success();
    }
}