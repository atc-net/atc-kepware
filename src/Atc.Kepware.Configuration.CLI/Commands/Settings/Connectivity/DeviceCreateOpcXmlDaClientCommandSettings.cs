namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateOpcXmlDaClientCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--update-mode")]
    [Description("Update mode: Exception (0) or Poll (1)")]
    [DefaultValue(OpcXmlDaClientUpdateMode.Exception)]
    public OpcXmlDaClientUpdateMode UpdateMode { get; init; }

    [CommandOption("--update-poll-rate")]
    [Description("Update/poll rate in milliseconds (100-3600000)")]
    [DefaultValue(5000)]
    public int UpdatePollRate { get; init; }

    [CommandOption("--language-id")]
    [Description("Language ID for text operations (0-65535)")]
    [DefaultValue(1033)]
    public int LanguageId { get; init; }

    [CommandOption("--hold-time")]
    [Description("Hold time in milliseconds (0-36000000), Exception mode only")]
    [DefaultValue(0)]
    public int HoldTime { get; init; }

    [CommandOption("--wait-time")]
    [Description("Wait time in milliseconds (0-36000000), Exception mode only")]
    [DefaultValue(0)]
    public int WaitTime { get; init; }

    [CommandOption("--percent-deadband")]
    [Description("Percent deadband for value changes (0-100), Exception mode only")]
    [DefaultValue(0f)]
    public float PercentDeadband { get; init; }

    [CommandOption("--max-items-per-read")]
    [Description("Maximum items per read request (1-512)")]
    [DefaultValue(512)]
    public int MaxItemsPerRead { get; init; }

    [CommandOption("--max-items-per-write")]
    [Description("Maximum items per write request (1-512)")]
    [DefaultValue(512)]
    public int MaxItemsPerWrite { get; init; }

    [CommandOption("--read-timeout")]
    [Description("Read timeout in milliseconds (100-2100000)")]
    [DefaultValue(5000)]
    public int ReadTimeout { get; init; }

    [CommandOption("--write-timeout")]
    [Description("Write timeout in milliseconds (100-2100000)")]
    [DefaultValue(5000)]
    public int WriteTimeout { get; init; }

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

        if (UpdatePollRate < 100 || UpdatePollRate > 3600000)
        {
            return ValidationResult.Error("--update-poll-rate must be between 100 and 3600000.");
        }

        if (LanguageId < 0 || LanguageId > 65535)
        {
            return ValidationResult.Error("--language-id must be between 0 and 65535.");
        }

        if (HoldTime < 0 || HoldTime > 36000000)
        {
            return ValidationResult.Error("--hold-time must be between 0 and 36000000.");
        }

        if (WaitTime < 0 || WaitTime > 36000000)
        {
            return ValidationResult.Error("--wait-time must be between 0 and 36000000.");
        }

        if (PercentDeadband < 0 || PercentDeadband > 100)
        {
            return ValidationResult.Error("--percent-deadband must be between 0 and 100.");
        }

        if (MaxItemsPerRead < 1 || MaxItemsPerRead > 512)
        {
            return ValidationResult.Error("--max-items-per-read must be between 1 and 512.");
        }

        if (MaxItemsPerWrite < 1 || MaxItemsPerWrite > 512)
        {
            return ValidationResult.Error("--max-items-per-write must be between 1 and 512.");
        }

        if (ReadTimeout < 100 || ReadTimeout > 2100000)
        {
            return ValidationResult.Error("--read-timeout must be between 100 and 2100000.");
        }

        if (WriteTimeout < 100 || WriteTimeout > 2100000)
        {
            return ValidationResult.Error("--write-timeout must be between 100 and 2100000.");
        }

        return ValidationResult.Success();
    }
}
