namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateMtConnectClientCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id [DEVICE-ID]")]
    [Description("MTConnect Device ID")]
    public FlagValue<string>? MtConnectDeviceId { get; init; }

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
