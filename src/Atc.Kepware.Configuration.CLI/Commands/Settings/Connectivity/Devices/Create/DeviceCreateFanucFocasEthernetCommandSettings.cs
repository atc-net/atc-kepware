namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Devices.Create;

public class DeviceCreateFanucFocasEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICE-ID>")]
    [Description("Device ID (IP Address of the CNC)")]
    public string DeviceId { get; init; } = string.Empty;

    [CommandOption("--model [MODEL]")]
    [Description("Device model (Series15i, Series16i, Series18i, Series21i, PowerMateI, Open)")]
    public FlagValue<FanucFocasDeviceModelType>? Model { get; init; } = new();

    [CommandOption("--port")]
    [Description("TCP/IP port number (0-65535)")]
    [DefaultValue(8193)]
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

    [CommandOption("--maximum-request-size [SIZE]")]
    [Description("Maximum request size in bytes (Bytes8, Bytes16, Bytes32, Bytes64, Bytes128, Bytes256, Bytes512)")]
    public FlagValue<FanucFocasMaximumRequestSizeType>? MaximumRequestSize { get; init; } = new();

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

        return ValidationResult.Success();
    }
}