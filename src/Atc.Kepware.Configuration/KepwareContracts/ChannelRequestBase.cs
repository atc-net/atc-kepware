namespace Atc.Kepware.Configuration.KepwareContracts;

internal abstract class ChannelRequestBase
{
    protected ChannelRequestBase(DriverType deviceDriver)
    {
        DeviceDriver = deviceDriver.GetDescription();
    }

    /// <summary>
    /// Specifies the identity of this object.
    /// </summary>
    [MinLength(1)]
    [MaxLength(256)]
    [JsonPropertyName("common.ALLTYPES_NAME")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Summary of this object or its use.
    /// </summary>
    [MaxLength(255)]
    [JsonPropertyName("common.ALLTYPES_DESCRIPTION")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("servermain.MULTIPLE_TYPES_DEVICE_DRIVER")]
    public string DeviceDriver { get; private init; }

    /// <summary>
    /// Indicates whether or not to make the channel's diagnostic information available to an OPC application.
    /// </summary>
    [JsonPropertyName("servermain.CHANNEL_DIAGNOSTICS_CAPTURE")]
    public bool? CaptureDiagnostics { get; set; }

    /// <summary>
    /// Determines how write data is passed to the underlying communications driver when more than one write exists in the write queue.
    /// </summary>
    [JsonPropertyName("servermain.CHANNEL_WRITE_OPTIMIZATIONS_METHOD")]
    public ChannelOptimizationMethodType OptimizationMethod { get; set; } = ChannelOptimizationMethodType.WriteOnlyLatestValueForAllTags;

    /// <summary>
    /// Specifies the ratio of write operations to read operations, based on one read per configurable number of writes.
    /// </summary>
    [Range(1, 10)]
    [JsonPropertyName("servermain.CHANNEL_WRITE_OPTIMIZATIONS_DUTY_CYCLE")]
    public int WriteOptimizationDutyCycle { get; set; } = 10;

    /// <summary>
    /// Determines how to send invalid floating-point numbers to the client.
    /// </summary>
    [JsonPropertyName("servermain.CHANNEL_NON_NORMALIZED_FLOATING_POINT_HANDLING")]
    public ChannelNonNormalizedFloatingPointHandlingType NonNormalizedFloatingPointHandling { get; set; } = ChannelNonNormalizedFloatingPointHandlingType.ReplaceWithZero;

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(DeviceDriver)}: {DeviceDriver}, {nameof(CaptureDiagnostics)}: {CaptureDiagnostics}, {nameof(OptimizationMethod)}: {OptimizationMethod}, {nameof(WriteOptimizationDutyCycle)}: {WriteOptimizationDutyCycle}, {nameof(NonNormalizedFloatingPointHandling)}: {NonNormalizedFloatingPointHandling}";
}