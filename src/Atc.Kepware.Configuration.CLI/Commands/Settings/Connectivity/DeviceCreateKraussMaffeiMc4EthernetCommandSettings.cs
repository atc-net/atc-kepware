namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateKraussMaffeiMc4EthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICE-ID>")]
    [Description("Device ID (IP Address of the injection molding machine)")]
    public string DeviceId { get; init; } = string.Empty;

    [CommandOption("--port")]
    [Description("TCP/IP port number (0-65535)")]
    [DefaultValue(2001)]
    public int Port { get; init; }

    [CommandOption("--machine-id")]
    [Description("Machine ID for the injection molding machine (1-255)")]
    [DefaultValue(1)]
    public int MachineId { get; init; }

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

        if (Port < 0 || Port > 65535)
        {
            return ValidationResult.Error("--port must be between 0 and 65535.");
        }

        if (MachineId < 1 || MachineId > 255)
        {
            return ValidationResult.Error("--machine-id must be between 1 and 255.");
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
