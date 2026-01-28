namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateOpcXmlDaClientCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--return-item-time")]
    [Description("Include timestamps in server responses")]
    [DefaultValue(true)]
    public bool ReturnItemTime { get; init; }

    [CommandOption("--return-item-path")]
    [Description("Include item paths in server responses")]
    [DefaultValue(false)]
    public bool ReturnItemPath { get; init; }

    [CommandOption("--return-item-name")]
    [Description("Include item names in server responses")]
    [DefaultValue(false)]
    public bool ReturnItemName { get; init; }

    [CommandOption("--return-diagnostic-info")]
    [Description("Include diagnostic information in server responses")]
    [DefaultValue(false)]
    public bool ReturnDiagnosticInfo { get; init; }

    [CommandOption("--return-error-text")]
    [Description("Include error text in server responses")]
    [DefaultValue(true)]
    public bool ReturnErrorText { get; init; }

    [CommandOption("--max-items-per-read")]
    [Description("Maximum items per read request (1-512)")]
    [DefaultValue(512)]
    public int MaxItemsPerRead { get; init; }

    [CommandOption("--max-items-per-write")]
    [Description("Maximum items per write request (1-512)")]
    [DefaultValue(512)]
    public int MaxItemsPerWrite { get; init; }

    [CommandOption("--read-after-write")]
    [Description("Perform a read after writes")]
    [DefaultValue(true)]
    public bool ReadAfterWrite { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (MaxItemsPerRead < 1 || MaxItemsPerRead > 512)
        {
            return ValidationResult.Error("--max-items-per-read must be between 1 and 512.");
        }

        if (MaxItemsPerWrite < 1 || MaxItemsPerWrite > 512)
        {
            return ValidationResult.Error("--max-items-per-write must be between 1 and 512.");
        }

        return ValidationResult.Success();
    }
}
