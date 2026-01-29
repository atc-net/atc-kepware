namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Devices.Create;

public class DeviceCreateDnpClientEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--dnp-client-address")]
    [Description("DNP client address (0-65519)")]
    [DefaultValue(3)]
    public int DnpClientAddress { get; init; }

    [CommandOption("--dnp-server-address")]
    [Description("DNP server address (0-65519)")]
    [DefaultValue(4)]
    public int DnpServerAddress { get; init; }

    [CommandOption("--request-timeout")]
    [Description("Request timeout in milliseconds (100-3600000)")]
    [DefaultValue(30000)]
    public int RequestTimeout { get; init; }

    [CommandOption("--max-timeouts")]
    [Description("Maximum timeouts before error (1-10)")]
    [DefaultValue(1)]
    public int MaxTimeouts { get; init; }

    [CommandOption("--keep-alive-interval")]
    [Description("Keep-alive interval in seconds (0-86400)")]
    [DefaultValue(0)]
    public int KeepAliveInterval { get; init; }

    [CommandOption("--dnp-server-uses-utc")]
    [Description("DNP server uses UTC time")]
    [DefaultValue(true)]
    public bool DnpServerUsesUtc { get; init; }

    [CommandOption("--dnp-server-respects-dst")]
    [Description("DNP server respects daylight saving time")]
    [DefaultValue(false)]
    public bool DnpServerRespectsDst { get; init; }

    [CommandOption("--honor-time-sync-requests")]
    [Description("Honor time sync requests from DNP server")]
    [DefaultValue(true)]
    public bool HonorTimeSyncRequests { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (DnpClientAddress < 0 || DnpClientAddress > 65519)
        {
            return ValidationResult.Error("--dnp-client-address must be between 0 and 65519.");
        }

        if (DnpServerAddress < 0 || DnpServerAddress > 65519)
        {
            return ValidationResult.Error("--dnp-server-address must be between 0 and 65519.");
        }

        if (RequestTimeout < 100 || RequestTimeout > 3600000)
        {
            return ValidationResult.Error("--request-timeout must be between 100 and 3600000.");
        }

        if (MaxTimeouts < 1 || MaxTimeouts > 10)
        {
            return ValidationResult.Error("--max-timeouts must be between 1 and 10.");
        }

        if (KeepAliveInterval < 0 || KeepAliveInterval > 86400)
        {
            return ValidationResult.Error("--keep-alive-interval must be between 0 and 86400.");
        }

        return ValidationResult.Success();
    }
}