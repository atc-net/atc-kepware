namespace Atc.Kepware.Configuration.CLI.Commands.Settings.IotGateway;

public sealed class IotItemUpdateCommandSettings : IotItemUpdateCommandBaseSettings
{
    [CommandOption("--scan-rate [SCAN-RATE]")]
    [Description("Specifies the frequency, in milliseconds, at which the iot item should be scanned")]
    public FlagValue<int>? ScanRate { get; init; }

    [CommandOption("--send-every-scan [SEND-EVERY-SCAN]")]
    [Description("Specifies if the tag should be published on every scan or only on data changes")]
    public FlagValue<bool>? SendEveryScan { get; init; }

    [CommandOption("--dead-band-percent [DEAD-BAND-PERCENT]")]
    [Description("Specifies the DeadBand (%) when SendEveryScan is false")]
    public FlagValue<int>? DeadBandPercent { get; init; }

    [CommandOption("--enabled [ENABLED]")]
    [Description("Indicates whether the Iot Item is enabled")]
    public FlagValue<bool>? Enabled { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (SendEveryScan is not null &&
            SendEveryScan.IsSet &&
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