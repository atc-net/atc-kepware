namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Devices.Create;

public class DeviceCreateIec61850MmsClientCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICE-ID>")]
    [Description("The IP address of the IEC 61850 MMS server")]
    public string DeviceId { get; init; } = "0.0.0.0";

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        return ValidationResult.Success();
    }
}