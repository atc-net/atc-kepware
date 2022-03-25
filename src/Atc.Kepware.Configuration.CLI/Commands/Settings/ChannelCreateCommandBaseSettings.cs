namespace Atc.Kepware.Configuration.CLI.Commands.Settings;

public class ChannelCreateCommandBaseSettings : KepwareBaseCommandSettings
{
    [CommandOption("-n|--name <NAME>")]
    [Description("Requested Name")]
    public string Name { get; init; } = string.Empty;

    [CommandOption("--description [DESCRIPTION]")]
    [Description("Requested Description")]
    public FlagValue<string>? Description { get; init; }

    [CommandOption("--capturediagnostics")]
    [Description("Indicates whether or not to make the channel's diagnostic information available to an OPC application.")]
    [DefaultValue(false)]
    public bool? CaptureDiagnostics { get; init; }

    [CommandOption("--optimizationmethod [OPTIMIZATIONMETHOD]")]
    [ChannelOptimizationMethodTypeDescription]
    public FlagValue<ChannelOptimizationMethodType>? OptimizationMethod { get; init; } = new();

    [CommandOption("--writeoptimizationdutycycle")]
    [Description("Specifies the ratio of write operations to read operations, based on one read per configurable number of writes.")]
    [DefaultValue(10)]
    public int WriteOptimizationDutyCycle { get; init; }

    [CommandOption("--nonnormalizedfloatingpointhandling [NONNORMALIZEDFLOATINGPOINTHANDLING]")]
    [ChannelNonNormalizedFloatingPointHandlingTypeDescription]
    public FlagValue<ChannelNonNormalizedFloatingPointHandlingType>? NonNormalizedFloatingPointHandling { get; init; } = new();

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (string.IsNullOrEmpty(Name))
        {
            return ValidationResult.Error("name is not set.");
        }

        return ValidationResult.Success();
    }
}