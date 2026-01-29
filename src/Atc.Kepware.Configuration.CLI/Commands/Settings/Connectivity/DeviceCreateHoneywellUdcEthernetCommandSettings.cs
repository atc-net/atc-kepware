namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateHoneywellUdcEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICE-ID>")]
    [Description("Device ID (IP Address, e.g., 192.168.1.1)")]
    public string DeviceId { get; init; } = string.Empty;

    [CommandOption("--model [MODEL]")]
    [Description("Device model (UDC2500, UDC3200, UDC3500)")]
    public FlagValue<HoneywellUdcEthernetDeviceModelType>? Model { get; init; } = new();

    [CommandOption("--port")]
    [Description("TCP/IP port number (0-65535)")]
    [DefaultValue(502)]
    public int Port { get; init; }

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

    [CommandOption("--first-word-low")]
    [Description("First word low in 32-bit values")]
    [DefaultValue(false)]
    public bool FirstWordLow { get; init; }

    [CommandOption("--internal-registers")]
    [Description("Number of internal registers per request (1-22)")]
    [DefaultValue(22)]
    public int InternalRegisters { get; init; }

    [CommandOption("--holding-registers")]
    [Description("Number of holding registers per request (1-22)")]
    [DefaultValue(22)]
    public int HoldingRegisters { get; init; }

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

        if (InternalRegisters < 1 || InternalRegisters > 22)
        {
            return ValidationResult.Error("--internal-registers must be between 1 and 22.");
        }

        if (HoldingRegisters < 1 || HoldingRegisters > 22)
        {
            return ValidationResult.Error("--holding-registers must be between 1 and 22.");
        }

        return ValidationResult.Success();
    }
}