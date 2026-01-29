namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Devices.Create;

public class DeviceCreateSiemensS7PlusEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICE-ID>")]
    [Description("Device IP address")]
    public string DeviceId { get; init; } = "255.255.255.255";

    [CommandOption("--port")]
    [Description("Port number for device (1-65535)")]
    [DefaultValue(102)]
    public int Port { get; init; }

    [CommandOption("--plc-password [PLC-PASSWORD]")]
    [Description("Password for the access level configured in the PLC")]
    public FlagValue<string>? PlcPassword { get; init; } = new();

    [CommandOption("--include-idbs-fbs")]
    [Description("Include Instance Data Blocks and Function Blocks in symbol load")]
    [DefaultValue(false)]
    public bool IncludeIdbsFbs { get; init; }

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

        if (Port < 1 || Port > 65535)
        {
            return ValidationResult.Error("--port must be between 1 and 65535.");
        }

        return ValidationResult.Success();
    }
}