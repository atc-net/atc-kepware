namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity;

internal class ChannelBase : IChannelBase
{
    /// <inheritdoc />
    [JsonPropertyName("common.ALLTYPES_NAME")]
    public string Name { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("common.ALLTYPES_DESCRIPTION")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("servermain.MULTIPLE_TYPES_DEVICE_DRIVER")]
    public string DeviceDriver { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_DIAGNOSTICS_CAPTURE")]
    public bool? CaptureDiagnostics { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_STATIC_TAG_COUNT")]
    public int TagCount { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_WRITE_OPTIMIZATIONS_METHOD")]
    public ChannelOptimizationMethodType OptimizationMethod { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_WRITE_OPTIMIZATIONS_DUTY_CYCLE")]
    public int WriteOptimizationDutyCycle { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_NON_NORMALIZED_FLOATING_POINT_HANDLING")]
    public ChannelNonNormalizedFloatingPointHandlingType NonNormalizedFloatingPointHandling { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(DeviceDriver)}: {DeviceDriver}, {nameof(CaptureDiagnostics)}: {CaptureDiagnostics}, {nameof(TagCount)}: {TagCount}, {nameof(OptimizationMethod)}: {OptimizationMethod}, {nameof(WriteOptimizationDutyCycle)}: {WriteOptimizationDutyCycle}, {nameof(NonNormalizedFloatingPointHandling)}: {NonNormalizedFloatingPointHandling}";
}