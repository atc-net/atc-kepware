namespace Atc.Kepware.Configuration.Contracts.Drivers;

public class ChannelBase
{
    /// <summary>
    /// Specify the identity of this object.
    /// </summary>
    [JsonPropertyName("common.ALLTYPES_NAME")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Provide a brief summary of this object or its use.
    /// </summary>
    [JsonPropertyName("common.ALLTYPES_DESCRIPTION")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("servermain.MULTIPLE_TYPES_DEVICE_DRIVER")]
    public string DeviceDriver { get; set; } = string.Empty;

    /// <summary>
    /// Select whether or not to make the channel's diagnostic information available to an OPC application.
    /// </summary>
    [JsonPropertyName("servermain.CHANNEL_DIAGNOSTICS_CAPTURE")]
    public bool? CaptureDiagnostics { get; set; }

    /// <summary>
    /// The total number of user defined tags assigned to the device.
    /// </summary>
    [JsonPropertyName("servermain.CHANNEL_STATIC_TAG_COUNT")]
    public int TagCount { get; set; }

    /// <summary>
    /// Choose how write data is passed to the underlying communications driver when more than one write exists in the write queue.
    /// </summary>
    [JsonPropertyName("servermain.CHANNEL_WRITE_OPTIMIZATIONS_METHOD")]
    public ChannelOptimizationMethodType OptimizationMethod { get; set; } = ChannelOptimizationMethodType.WriteOnlyLatestValueForAllTags;

    /// <summary>
    /// Specify the ratio of write operations to read operations, based on one read per configurable number of writes.
    /// </summary>
    [JsonPropertyName("servermain.CHANNEL_WRITE_OPTIMIZATIONS_DUTY_CYCLE")]
    public int WriteOptimizationDutyCycle { get; set; } = 10;

    /// <summary>
    /// Choose how to send invalid floating-point numbers to the client.
    /// </summary>
    [JsonPropertyName("servermain.CHANNEL_NON_NORMALIZED_FLOATING_POINT_HANDLING")]
    public ChannelNonNormalizedFloatingPointHandlingType NonNormalizedFloatingPointHandling { get; set; } = ChannelNonNormalizedFloatingPointHandlingType.ReplaceWithZero;

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(DeviceDriver)}: {DeviceDriver}, {nameof(CaptureDiagnostics)}: {CaptureDiagnostics}, {nameof(TagCount)}: {TagCount}, {nameof(OptimizationMethod)}: {OptimizationMethod}, {nameof(WriteOptimizationDutyCycle)}: {WriteOptimizationDutyCycle}, {nameof(NonNormalizedFloatingPointHandling)}: {NonNormalizedFloatingPointHandling}";
}