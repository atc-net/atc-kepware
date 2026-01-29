namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

/// <summary>
/// Command settings for creating a Wonderware InTouch Client device.
/// </summary>
public class DeviceCreateWonderwareIntouchClientCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--model [MODEL]")]
    [Description("Device model: InTouch or InTouchReadOnly")]
    public FlagValue<WonderwareIntouchClientDeviceModel>? Model { get; init; } = new();

    [CommandOption("--import-method [IMPORT-METHOD]")]
    [Description("Tag import method: ImportFromInTouchProject or ImportFromInTouchCsvFile")]
    public FlagValue<WonderwareIntouchClientImportMethod>? ImportMethod { get; init; } = new();

    [CommandOption("--intouch-project-folder [FOLDER]")]
    [Description("InTouch project folder path for importing tags")]
    public FlagValue<string>? InTouchProjectFolder { get; init; } = new();

    [CommandOption("--intouch-csv-file [FILE]")]
    [Description("InTouch CSV file path for importing tags")]
    public FlagValue<string>? InTouchCsvFile { get; init; } = new();

    [CommandOption("--include-tag-descriptions [INCLUDE]")]
    [Description("Include tag descriptions when importing tags (default: true)")]
    public FlagValue<bool>? IncludeTagDescriptions { get; init; } = new();

    [CommandOption("--import-system-tags [IMPORT]")]
    [Description("Import InTouch system tags (default: true)")]
    public FlagValue<bool>? ImportSystemTags { get; init; } = new();

    [CommandOption("--tag-naming [TAG-NAMING]")]
    [Description("Tag naming option: Legacy or Enhanced (default: Enhanced)")]
    public FlagValue<WonderwareIntouchClientTagNaming>? TagNaming { get; init; } = new();

    [CommandOption("--mode [MODE]")]
    [Description("Data access mode: DriverPollsInTouch, InTouchNotifiesDriver, or Combination")]
    public FlagValue<WonderwareIntouchClientMode>? Mode { get; init; } = new();

    [CommandOption("--maximum-active-time-ms [MS]")]
    [Description("Maximum time to keep tags active in milliseconds (0-3600000, default: 60000)")]
    public FlagValue<int>? MaximumActiveTimeMs { get; init; } = new();

    [CommandOption("--delete-inactive-tags [DELETE]")]
    [Description("Delete tags between reads (default: true)")]
    public FlagValue<bool>? DeleteInactiveTags { get; init; } = new();

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (MaximumActiveTimeMs is { IsSet: true, Value: < 0 or > 3600000 })
        {
            return ValidationResult.Error("--maximum-active-time-ms must be between 0 and 3600000.");
        }

        return ValidationResult.Success();
    }
}