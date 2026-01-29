namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Devices.Create;

public class DeviceCreateCutlerHammerElcEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--model")]
    [Description("Device model (Pv28Series)")]
    [DefaultValue(CutlerHammerElcEthernetDeviceModelType.Pv28Series)]
    public CutlerHammerElcEthernetDeviceModelType Model { get; init; }

    [CommandOption("--id-format")]
    [Description("Device ID format (Octal, Decimal, Hex)")]
    [DefaultValue(CutlerHammerElcEthernetDeviceIdFormatType.Octal)]
    public CutlerHammerElcEthernetDeviceIdFormatType IdFormat { get; init; }

    [CommandOption("--device-id <DEVICE-ID>")]
    [Description("Device IP address and unit ID (e.g., <192.168.1.1>.0)")]
    public string DeviceId { get; init; } = "<255.255.255.255>.0";

    [CommandOption("--port")]
    [Description("Port number (0-65535)")]
    [DefaultValue(502)]
    public int PortNumber { get; init; }

    [CommandOption("--output-coils")]
    [Description("Number of discrete outputs to read (8-1024, multiple of 8)")]
    [DefaultValue(1024)]
    public int OutputCoils { get; init; }

    [CommandOption("--input-coils")]
    [Description("Number of discrete inputs to read (8-1024, multiple of 8)")]
    [DefaultValue(1024)]
    public int InputCoils { get; init; }

    [CommandOption("--holding-registers")]
    [Description("Number of holding registers to read (1-120)")]
    [DefaultValue(120)]
    public int HoldingRegisters { get; init; }

    [CommandOption("--first-word-low")]
    [Description("First word is the low word of a 32-bit value")]
    [DefaultValue(false)]
    public bool FirstWordLow { get; init; }

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
            return ValidationResult.Error("--port must be between 0 and 65535.");
        }

        if (OutputCoils < 8 || OutputCoils > 1024)
        {
            return ValidationResult.Error("--output-coils must be between 8 and 1024.");
        }

        if (OutputCoils % 8 != 0)
        {
            return ValidationResult.Error("--output-coils must be a multiple of 8.");
        }

        if (InputCoils < 8 || InputCoils > 1024)
        {
            return ValidationResult.Error("--input-coils must be between 8 and 1024.");
        }

        if (InputCoils % 8 != 0)
        {
            return ValidationResult.Error("--input-coils must be a multiple of 8.");
        }

        if (HoldingRegisters < 1 || HoldingRegisters > 120)
        {
            return ValidationResult.Error("--holding-registers must be between 1 and 120.");
        }

        return ValidationResult.Success();
    }
}