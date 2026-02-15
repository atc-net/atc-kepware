namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Meters;

public class MeterCommandBaseSettings : ChannelAndDeviceCommandBaseSettings
{
    [CommandOption("-m|--meter-group-name <METER-GROUP-NAME>")]
    [Description("MeterGroupName")]
    public string MeterGroupName { get; init; } = string.Empty;

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        var isValidMeterGroupName = IsValidName("meter-group-name", MeterGroupName);
        return isValidMeterGroupName.Successful
            ? ValidationResult.Success()
            : isValidMeterGroupName;
    }
}