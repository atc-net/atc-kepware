namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateYaskawaMpSeriesEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICE-ID>")]
    [Description("Device IP address")]
    public string DeviceId { get; init; } = string.Empty;

    [CommandOption("--port-number")]
    [Description("Port number (0-65535)")]
    [DefaultValue(502)]
    public int PortNumber { get; init; }

    [CommandOption("--input-bits")]
    [Description("Input Bits block size, must be a multiple of 8 (8-800)")]
    [DefaultValue(32)]
    public int InputBits { get; init; }

    [CommandOption("--output-bits")]
    [Description("Output Bits block size, must be a multiple of 8 (8-800)")]
    [DefaultValue(32)]
    public int OutputBits { get; init; }

    [CommandOption("--input-words")]
    [Description("Input Words (in words) per request (1-120)")]
    [DefaultValue(32)]
    public int InputWords { get; init; }

    [CommandOption("--output-words")]
    [Description("Output Words (in words) per request (1-120)")]
    [DefaultValue(32)]
    public int OutputWords { get; init; }

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
            return ValidationResult.Error("--port-number must be between 0 and 65535.");
        }

        if (InputBits < 8 || InputBits > 800)
        {
            return ValidationResult.Error("--input-bits must be between 8 and 800.");
        }

        if (InputBits % 8 != 0)
        {
            return ValidationResult.Error("--input-bits must be a multiple of 8.");
        }

        if (OutputBits < 8 || OutputBits > 800)
        {
            return ValidationResult.Error("--output-bits must be between 8 and 800.");
        }

        if (OutputBits % 8 != 0)
        {
            return ValidationResult.Error("--output-bits must be a multiple of 8.");
        }

        if (InputWords < 1 || InputWords > 120)
        {
            return ValidationResult.Error("--input-words must be between 1 and 120.");
        }

        if (OutputWords < 1 || OutputWords > 120)
        {
            return ValidationResult.Error("--output-words must be between 1 and 120.");
        }

        return ValidationResult.Success();
    }
}