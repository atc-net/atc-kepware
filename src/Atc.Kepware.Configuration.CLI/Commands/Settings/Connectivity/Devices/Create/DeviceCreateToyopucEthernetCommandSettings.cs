namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Devices.Create;

public class DeviceCreateToyopucEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICE-ID>")]
    [Description("Device IP address")]
    public string DeviceId { get; init; } = "127.0.0.1";

    [CommandOption("--model [MODEL]")]
    [Description("Device model (Pc2_Pc2Interchange, Pc3Device, Pc10GDevice)")]
    public FlagValue<ToyopucEthernetDeviceModelType>? Model { get; init; } = new();

    [CommandOption("--device-port")]
    [Description("Device port number (1025-65534)")]
    [DefaultValue(4096)]
    public int DevicePort { get; init; }

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

        if (DevicePort < 1025 || DevicePort > 65534)
        {
            return ValidationResult.Error("--device-port must be between 1025 and 65534.");
        }

        return ValidationResult.Success();
    }
}