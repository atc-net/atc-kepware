namespace Atc.Kepware.Configuration.KepwareContracts;

internal abstract class ChannelRequestBase : IChannelRequestBase
{
    protected ChannelRequestBase(DriverType deviceDriver)
    {
        DeviceDriver = deviceDriver.GetDescription();
    }

    /// <inheritdoc />
    [KeyString]
    [JsonPropertyName("common.ALLTYPES_NAME")]
    public string Name { get; set; } = string.Empty;

    /// <inheritdoc />
    [MaxLength(255)]
    [JsonPropertyName("common.ALLTYPES_DESCRIPTION")]
    public string Description { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("servermain.MULTIPLE_TYPES_DEVICE_DRIVER")]
    public string DeviceDriver { get; private init; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_DIAGNOSTICS_CAPTURE")]
    public bool? CaptureDiagnostics { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_WRITE_OPTIMIZATIONS_METHOD")]
    public ChannelOptimizationMethodType OptimizationMethod { get; set; } = ChannelOptimizationMethodType.WriteOnlyLatestValueForAllTags;

    /// <inheritdoc />
    [Range(1, 10)]
    [JsonPropertyName("servermain.CHANNEL_WRITE_OPTIMIZATIONS_DUTY_CYCLE")]
    public int WriteOptimizationDutyCycle { get; set; } = 10;

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_NON_NORMALIZED_FLOATING_POINT_HANDLING")]
    public ChannelNonNormalizedFloatingPointHandlingType NonNormalizedFloatingPointHandling { get; set; } = ChannelNonNormalizedFloatingPointHandlingType.ReplaceWithZero;

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(DeviceDriver)}: {DeviceDriver}, {nameof(CaptureDiagnostics)}: {CaptureDiagnostics}, {nameof(OptimizationMethod)}: {OptimizationMethod}, {nameof(WriteOptimizationDutyCycle)}: {WriteOptimizationDutyCycle}, {nameof(NonNormalizedFloatingPointHandling)}: {NonNormalizedFloatingPointHandling}";
}