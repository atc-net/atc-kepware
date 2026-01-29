namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Devices.Create;

public class DeviceCreateIec608705104ClientCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--common-address")]
    [Description("Common Address for the device (0-65534)")]
    [DefaultValue(3)]
    public int CommonAddress { get; init; } = 3;

    [CommandOption("--polled-reads")]
    [Description("Perform polled reads when last-read data is older than the scan rate")]
    [DefaultValue(true)]
    public bool PolledReads { get; init; } = true;

    [CommandOption("--request-timeout")]
    [Description("Request timeout in milliseconds")]
    [DefaultValue(10000)]
    public int RequestTimeout { get; init; } = 10000;

    [CommandOption("--interrogation-request-timeout")]
    [Description("Interrogation request timeout in milliseconds")]
    [DefaultValue(60000)]
    public int InterrogationRequestTimeout { get; init; } = 60000;

    [CommandOption("--attempt-count")]
    [Description("Number of basic communication attempts (1-10)")]
    [DefaultValue(3)]
    public int AttemptCount { get; init; } = 3;

    [CommandOption("--interrogation-attempt-count")]
    [Description("Number of interrogation attempts (1-10)")]
    [DefaultValue(3)]
    public int InterrogationAttemptCount { get; init; } = 3;

    [CommandOption("--time-sync-initialization [TIME-SYNC-INITIALIZATION]")]
    [Description("When to send Time Syncs")]
    public FlagValue<Iec608705104InitializationType>? TimeSyncInitialization { get; init; } = new();

    [CommandOption("--gi-initialization [GI-INITIALIZATION]")]
    [Description("When to send General Interrogations")]
    public FlagValue<Iec608705104InitializationType>? GiInitialization { get; init; } = new();

    [CommandOption("--ci-initialization [CI-INITIALIZATION]")]
    [Description("When to send Counter Interrogations")]
    public FlagValue<Iec608705104InitializationType>? CiInitialization { get; init; } = new();

    [CommandOption("--periodic-gi-interval")]
    [Description("Interval in minutes to send a General Interrogation (0 disables)")]
    [DefaultValue(720)]
    public int PeriodicGiInterval { get; init; } = 720;

    [CommandOption("--periodic-ci-interval")]
    [Description("Interval in minutes to send a Counter Interrogation (0 disables)")]
    [DefaultValue(0)]
    public int PeriodicCiInterval { get; init; }

    [CommandOption("--test-procedure")]
    [Description("Send a test command periodically")]
    [DefaultValue(true)]
    public bool TestProcedure { get; init; } = true;

    [CommandOption("--test-procedure-period")]
    [Description("Rate in seconds at which the Test Command will occur (1-86400)")]
    [DefaultValue(15)]
    public int TestProcedurePeriod { get; init; } = 15;

    [CommandOption("--playback-events")]
    [Description("Play back events for buffered data")]
    [DefaultValue(true)]
    public bool PlaybackEvents { get; init; } = true;

    [CommandOption("--playback-buffer-size")]
    [Description("Number of events each tag can buffer (1-10000)")]
    [DefaultValue(100)]
    public int PlaybackBufferSize { get; init; } = 100;

    [CommandOption("--playback-rate")]
    [Description("Rate in milliseconds at which events are played back (50-10000)")]
    [DefaultValue(2000)]
    public int PlaybackRate { get; init; } = 2000;

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (CommonAddress < 0 || CommonAddress > 65534)
        {
            return ValidationResult.Error("--common-address must be between 0 and 65534.");
        }

        if (RequestTimeout < 1)
        {
            return ValidationResult.Error("--request-timeout must be at least 1.");
        }

        if (InterrogationRequestTimeout < 1)
        {
            return ValidationResult.Error("--interrogation-request-timeout must be at least 1.");
        }

        if (AttemptCount < 1 || AttemptCount > 10)
        {
            return ValidationResult.Error("--attempt-count must be between 1 and 10.");
        }

        if (InterrogationAttemptCount < 1 || InterrogationAttemptCount > 10)
        {
            return ValidationResult.Error("--interrogation-attempt-count must be between 1 and 10.");
        }

        if (PeriodicGiInterval < 0)
        {
            return ValidationResult.Error("--periodic-gi-interval must be at least 0.");
        }

        if (PeriodicCiInterval < 0)
        {
            return ValidationResult.Error("--periodic-ci-interval must be at least 0.");
        }

        if (TestProcedurePeriod < 1 || TestProcedurePeriod > 86400)
        {
            return ValidationResult.Error("--test-procedure-period must be between 1 and 86400.");
        }

        if (PlaybackBufferSize < 1 || PlaybackBufferSize > 10000)
        {
            return ValidationResult.Error("--playback-buffer-size must be between 1 and 10000.");
        }

        if (PlaybackRate < 50 || PlaybackRate > 10000)
        {
            return ValidationResult.Error("--playback-rate must be between 50 and 10000.");
        }

        return ValidationResult.Success();
    }
}