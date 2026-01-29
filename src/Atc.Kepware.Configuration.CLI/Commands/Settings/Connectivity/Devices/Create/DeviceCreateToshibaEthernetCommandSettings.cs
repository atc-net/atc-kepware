namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Devices.Create;

public class DeviceCreateToshibaEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICE-ID>")]
    [Description("Device IP address")]
    public string DeviceId { get; init; } = string.Empty;

    [CommandOption("--port-number")]
    [Description("Port number (0-65535)")]
    [DefaultValue(1024)]
    public int PortNumber { get; init; }

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