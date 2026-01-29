namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateWagoEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICE-ID>")]
    [Description("Device IP address (e.g., 192.168.1.1)")]
    public string DeviceId { get; init; } = "255.255.255.255";

    [CommandOption("--port")]
    [Description("Port number (0-65535)")]
    [DefaultValue(502)]
    public int PortNumber { get; init; }

    [CommandOption("--input-coils")]
    [Description("Maximum input coil size in bits for reading (8-800 in multiples of 8)")]
    [DefaultValue(32)]
    public int InputCoils { get; init; }

    [CommandOption("--output-coils")]
    [Description("Maximum output coil size in bits for reading (8-800 in multiples of 8)")]
    [DefaultValue(32)]
    public int OutputCoils { get; init; }

    [CommandOption("--internal-registers")]
    [Description("Maximum internal register size in words for reading (1-120)")]
    [DefaultValue(32)]
    public int InternalRegisters { get; init; }

    [CommandOption("--holding-registers")]
    [Description("Maximum holding register size in words for reading (1-120)")]
    [DefaultValue(32)]
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

        if (PortNumber < 0 || PortNumber > 65535)
        {
            return ValidationResult.Error("--port must be between 0 and 65535.");
        }

        if (InputCoils < 8 || InputCoils > 800)
        {
            return ValidationResult.Error("--input-coils must be between 8 and 800.");
        }

        if (OutputCoils < 8 || OutputCoils > 800)
        {
            return ValidationResult.Error("--output-coils must be between 8 and 800.");
        }

        if (InternalRegisters < 1 || InternalRegisters > 120)
        {
            return ValidationResult.Error("--internal-registers must be between 1 and 120.");
        }

        if (HoldingRegisters < 1 || HoldingRegisters > 120)
        {
            return ValidationResult.Error("--holding-registers must be between 1 and 120.");
        }

        return ValidationResult.Success();
    }
}
