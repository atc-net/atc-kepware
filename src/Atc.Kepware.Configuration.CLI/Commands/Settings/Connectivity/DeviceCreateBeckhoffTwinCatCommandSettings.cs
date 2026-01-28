namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateBeckhoffTwinCatCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICE-ID>")]
    [Description("Device ID in AmsNetId format (e.g., '255.255.255.255.1.1')")]
    public string DeviceId { get; init; } = string.Empty;

    [CommandOption("--model [MODEL]")]
    [Description("Device model (TwinCatPlc, BcBxController)")]
    public FlagValue<BeckhoffTwinCatModel>? Model { get; init; } = new();

    [CommandOption("--id-format [ID-FORMAT]")]
    [Description("Device ID format (Octal, Decimal, Hex)")]
    public FlagValue<BeckhoffTwinCatIdFormat>? IdFormat { get; init; } = new();

    [CommandOption("--port-number")]
    [Description("Port number for the Beckhoff device (0-65535)")]
    [DefaultValue(801)]
    public int PortNumber { get; init; }

    [CommandOption("--default-type [DEFAULT-TYPE]")]
    [Description("Default data type for tag addressing (String, Boolean, Char, Byte, Short, Word, Long, DWord, Float, Double)")]
    public FlagValue<BeckhoffTwinCatDefaultType>? DefaultType { get; init; } = new();

    [CommandOption("--import-source [IMPORT-SOURCE]")]
    [Description("Import source for controller Symbolic Information (Device, File)")]
    public FlagValue<BeckhoffTwinCatImportSource>? ImportSource { get; init; } = new();

    [CommandOption("--symbol-file [SYMBOL-FILE]")]
    [Description("Location of the .tpy file from which tags will be imported")]
    public FlagValue<string>? SymbolFile { get; init; }

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

        return ValidationResult.Success();
    }
}
