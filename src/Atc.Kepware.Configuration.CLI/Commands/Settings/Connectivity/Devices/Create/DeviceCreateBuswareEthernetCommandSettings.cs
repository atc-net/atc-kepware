namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Devices.Create;

public class DeviceCreateBuswareEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICE-ID>")]
    [Description("Device IP address (e.g., 192.168.1.1)")]
    public string DeviceId { get; init; } = "255.255.255.255";

    [CommandOption("--port")]
    [Description("Port number (0-65535)")]
    [DefaultValue(502)]
    public int PortNumber { get; init; }

    [CommandOption("--output-discretes")]
    [Description("Maximum discrete output block size for reading (8-800)")]
    [DefaultValue(32)]
    public int OutputDiscretes { get; init; }

    [CommandOption("--input-discretes")]
    [Description("Maximum discrete input block size for reading (8-800)")]
    [DefaultValue(32)]
    public int InputDiscretes { get; init; }

    [CommandOption("--output-registers")]
    [Description("Maximum register output block size for reading (1-120)")]
    [DefaultValue(32)]
    public int OutputRegisters { get; init; }

    [CommandOption("--input-registers")]
    [Description("Maximum register input block size for reading (1-120)")]
    [DefaultValue(32)]
    public int InputRegisters { get; init; }

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

        if (OutputDiscretes < 8 || OutputDiscretes > 800)
        {
            return ValidationResult.Error("--output-discretes must be between 8 and 800.");
        }

        if (InputDiscretes < 8 || InputDiscretes > 800)
        {
            return ValidationResult.Error("--input-discretes must be between 8 and 800.");
        }

        if (OutputRegisters < 1 || OutputRegisters > 120)
        {
            return ValidationResult.Error("--output-registers must be between 1 and 120.");
        }

        if (InputRegisters < 1 || InputRegisters > 120)
        {
            return ValidationResult.Error("--input-registers must be between 1 and 120.");
        }

        return ValidationResult.Success();
    }
}