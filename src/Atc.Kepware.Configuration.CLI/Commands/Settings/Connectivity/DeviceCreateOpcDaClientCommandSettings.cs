namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateOpcDaClientCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--group-name [GROUP-NAME]")]
    [Description("Optional name for identifying the group")]
    public FlagValue<string>? GroupName { get; init; } = new();

    [CommandOption("--update-mode [UPDATE-MODE]")]
    [Description("Update mode (Exception, Poll)")]
    public FlagValue<OpcDaClientUpdateMode>? UpdateMode { get; init; } = new();

    [CommandOption("--update-poll-rate")]
    [Description("Data update rate in milliseconds (0-3600000)")]
    [DefaultValue(1000)]
    public int UpdatePollRate { get; init; }

    [CommandOption("--percent-deadband")]
    [Description("Percent change in data required to notify client (0-100)")]
    [DefaultValue(0f)]
    public float PercentDeadband { get; init; }

    [CommandOption("--language-id")]
    [Description("Language ID for text operations (0-65535)")]
    [DefaultValue(1033)]
    public int LanguageId { get; init; }

    [CommandOption("--write-method [WRITE-METHOD]")]
    [Description("Write method (Asynchronous, Synchronous)")]
    public FlagValue<OpcDaClientReadWriteMethod>? WriteMethod { get; init; } = new();

    [CommandOption("--read-method [READ-METHOD]")]
    [Description("Read method (Asynchronous, Synchronous)")]
    public FlagValue<OpcDaClientReadWriteMethod>? ReadMethod { get; init; } = new();

    [CommandOption("--max-items-per-read")]
    [Description("Maximum items per read request (1-512)")]
    [DefaultValue(512)]
    public int MaxItemsPerRead { get; init; }

    [CommandOption("--max-items-per-write")]
    [Description("Maximum items per write request (1-512)")]
    [DefaultValue(512)]
    public int MaxItemsPerWrite { get; init; }

    [CommandOption("--write-timeout")]
    [Description("Write timeout in milliseconds (100-30000)")]
    [DefaultValue(1000)]
    public int WriteTimeout { get; init; }

    [CommandOption("--read-after-write")]
    [Description("Perform a read after writes")]
    [DefaultValue(true)]
    public bool ReadAfterWrite { get; init; }

    [CommandOption("--watchdog")]
    [Description("Enable watchdog callback monitoring")]
    [DefaultValue(false)]
    public bool Watchdog { get; init; }

    [CommandOption("--watchdog-item-id [WATCHDOG-ITEM-ID]")]
    [Description("Item ID of the watchdog tag")]
    public FlagValue<string>? WatchdogItemId { get; init; } = new();

    [CommandOption("--missed-updates-before-reconnect")]
    [Description("Number of missed updates before reconnecting (2-10)")]
    [DefaultValue(3)]
    public int MissedUpdatesBeforeReconnect { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (UpdatePollRate < 0 || UpdatePollRate > 3600000)
        {
            return ValidationResult.Error("--update-poll-rate must be between 0 and 3600000.");
        }

        if (PercentDeadband < 0 || PercentDeadband > 100)
        {
            return ValidationResult.Error("--percent-deadband must be between 0 and 100.");
        }

        if (LanguageId < 0 || LanguageId > 65535)
        {
            return ValidationResult.Error("--language-id must be between 0 and 65535.");
        }

        if (MaxItemsPerRead < 1 || MaxItemsPerRead > 512)
        {
            return ValidationResult.Error("--max-items-per-read must be between 1 and 512.");
        }

        if (MaxItemsPerWrite < 1 || MaxItemsPerWrite > 512)
        {
            return ValidationResult.Error("--max-items-per-write must be between 1 and 512.");
        }

        if (WriteTimeout < 100 || WriteTimeout > 30000)
        {
            return ValidationResult.Error("--write-timeout must be between 100 and 30000.");
        }

        if (MissedUpdatesBeforeReconnect < 2 || MissedUpdatesBeforeReconnect > 10)
        {
            return ValidationResult.Error("--missed-updates-before-reconnect must be between 2 and 10.");
        }

        return ValidationResult.Success();
    }
}
