namespace Atc.Kepware.Configuration.CLI.Commands.Settings;

public class TagCreateCommandSettings : ChannelAndDeviceCommandBaseSettings
{
    [CommandOption("--name <NAME>")]
    [Description("Tag Name")]
    public string Name { get; init; } = string.Empty;

    [CommandOption("--address <ADDRESS>")]
    [Description("The tag address")]
    public string Address { get; set; } = string.Empty;

    [CommandOption("--scan-rate <SCAN-RATE>")]
    [Description("Specifies the poll interval, in milliseconds, for this tag.")]
    public int ScanRate { get; set; }

    [CommandOption("--data-type [DATA-TYPE]")]
    [TagDataTypeDescription]
    public FlagValue<TagDataType>? DataType { get; init; } = new();

    [CommandOption("--client-access [TAG-CLIENT-ACCESS]")]
    [TagClientAccessTypeDescription]
    public FlagValue<TagClientAccessType>? ClientAccess { get; init; } = new();

    [CommandOption("--description")]
    [Description("Tag Description")]
    public string Description { get; set; } = string.Empty;

    [CommandOption("--tag-group")]
    [Description("Tag Groups indicating tree structure.")]
    public string[] TagGroups { get; init; } = Array.Empty<string>();

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        var isValidName = IsValidName(Name);
        if (!isValidName.Successful)
        {
            return isValidName;
        }

        if (string.IsNullOrEmpty(Address))
        {
            return ValidationResult.Error("--address is not set.");
        }

        if (DataType is null || !DataType.IsSet)
        {
            return ValidationResult.Error("--data-type is not set.");
        }

        if (ClientAccess is null || !ClientAccess.IsSet)
        {
            return ValidationResult.Error("--client-access is not set.");
        }

        if (ScanRate <= 0)
        {
            return ValidationResult.Error("--scan-rate is not set or not valid.");
        }

        return ValidationResult.Success();
    }
}