namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateMtConnectClientCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--port-number [PORT-NUMBER]")]
    [Description("Port number (0-65535, default: 80)")]
    public FlagValue<int>? PortNumber { get; init; }

    [CommandOption("--close-connection-after-request")]
    [Description("Close agent connection after each request (default: true)")]
    public FlagValue<bool>? CloseAgentConnectionAfterEachRequest { get; init; }

    [CommandOption("--schema-tag-validation")]
    [Description("Enable schema tag validation (default: true)")]
    public FlagValue<bool>? SchemaTagValidation { get; init; }

    [CommandOption("--read-all-items-single-request")]
    [Description("Read all items in a single request (default: true)")]
    public FlagValue<bool>? ReadAllItemsInSingleRequest { get; init; }

    [CommandOption("--items-per-request [ITEMS-PER-REQUEST]")]
    [Description("Items per request when not reading all items in single request (1-100, default: 25)")]
    public FlagValue<int>? ItemsPerRequest { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (PortNumber is { IsSet: true, Value: < 0 or > 65535 })
        {
            return ValidationResult.Error("Port number must be between 0 and 65535.");
        }

        if (ItemsPerRequest is { IsSet: true, Value: < 1 or > 100 })
        {
            return ValidationResult.Error("Items per request must be between 1 and 100.");
        }

        return ValidationResult.Success();
    }
}
