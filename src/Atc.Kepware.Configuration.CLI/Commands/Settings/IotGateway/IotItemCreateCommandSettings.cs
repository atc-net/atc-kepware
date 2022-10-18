namespace Atc.Kepware.Configuration.CLI.Commands.Settings.IotGateway;

public class IotItemCreateCommandSettings : IotItemCommandBaseSettings
{
    [CommandOption("--server-tag <SERVER-TAG>")]
    [Description("The server tag the Iot Item is pointing to")]
    public string ServerTag { get; init; } = string.Empty;

    [CommandOption("--scan-rate <SCAN-RATE>")]
    [Description("Specifies the frequency, in milliseconds, at which the iot item should be scanned (default: 10000)")]
    [DefaultValue(10000)]
    public int ScanRate { get; init; }

    [CommandOption("--send-every-scan")]
    [Description("Specifies if the tag should be published on every scan or only on data changes (default: false)")]
    [DefaultValue(false)]
    public bool? SendEveryScan { get; init; }

    [CommandOption("--dead-band-percent [DEAD-BAND-PERCENT]")]
    [Description("Specifies the DeadBand (%) when SendEveryScan is false (default: 0)")]
    [DefaultValue(0)]
    public FlagValue<int>? DeadBandPercent { get; init; }

    [CommandOption("--enabled")]
    [Description("Indicates whether the Iot Item is enabled (default: true)")]
    [DefaultValue(true)]
    public bool? Enabled { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (SendEveryScan.HasValue &&
            SendEveryScan.Value &&
            DeadBandPercent is not null &&
            DeadBandPercent.IsSet)
        {
            return ValidationResult.Error("--dead-band-percent is only valid when --send-every-scan is false.");
        }

        if (DeadBandPercent is not null &&
            DeadBandPercent.IsSet &&
            DeadBandPercent.Value is < 0 or > 100)
        {
            return ValidationResult.Error("--dead-band-percent must be between 0 and 100.");
        }

        return ValidationResult.Success();
    }
}