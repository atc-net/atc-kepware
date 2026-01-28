namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateAutomationDirectProductivitySeriesEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICE-ID>")]
    [Description("Device ID in format IP_Address:UnitID (e.g., 192.168.1.1:1)")]
    public string DeviceId { get; init; } = "255.255.255.255:255";

    [CommandOption("--port")]
    [Description("Port number for device (0-65535)")]
    [DefaultValue(502)]
    public int Port { get; init; }

    [CommandOption("--first-word-high")]
    [Description("First word is high in 32-bit values")]
    [DefaultValue(true)]
    public bool FirstWordHigh { get; init; }

    [CommandOption("--tag-import-file [TAG-IMPORT-FILE]")]
    [Description("Tag import file path")]
    public FlagValue<string>? TagImportFile { get; init; } = new();

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

        return ValidationResult.Success();
    }
}
