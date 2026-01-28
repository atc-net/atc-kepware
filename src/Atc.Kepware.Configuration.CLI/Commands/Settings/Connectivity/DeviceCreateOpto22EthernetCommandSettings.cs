namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateOpto22EthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICE-ID>")]
    [Description("Device ID (IP Address)")]
    public string DeviceId { get; init; } = string.Empty;

    [CommandOption("--model [MODEL]")]
    [Description("Device model (SnapPacR1, SnapPacR2, SnapPacS1, SnapPacS2, SnapPacEb1, SnapPacEb2, SnapEthernetBrain, SnapUltimateBrain, SnapLce, Mistic, E1, E2)")]
    public FlagValue<Opto22EthernetDeviceModelType>? Model { get; init; } = new();

    [CommandOption("--port")]
    [Description("Port number for device")]
    [DefaultValue(2001)]
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
