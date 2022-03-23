namespace Atc.Kepware.Configuration.Contracts;

public abstract class ChannelRequestBase
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
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Summary of this object or its use.
    /// </summary>
    [MaxLength(255)]
    public string Description { get; set; } = string.Empty;

    public string DeviceDriver { get; private init; }

    /// <summary>
    /// Indicates whether or not to make the channel's diagnostic information available to an OPC application.
    /// </summary>
    public bool? CaptureDiagnostics { get; set; }

    /// <summary>
    /// Determines how write data is passed to the underlying communications driver when more than one write exists in the write queue.
    /// </summary>
    public ChannelOptimizationMethodType OptimizationMethod { get; set; } = ChannelOptimizationMethodType.WriteOnlyLatestValueForAllTags;

    /// <summary>
    /// Specifies the ratio of write operations to read operations, based on one read per configurable number of writes.
    /// </summary>
    [Range(1, 10)]
    public int WriteOptimizationDutyCycle { get; set; } = 10;

    /// <summary>
    /// Determines how to send invalid floating-point numbers to the client.
    /// </summary>
    public ChannelNonNormalizedFloatingPointHandlingType NonNormalizedFloatingPointHandling { get; set; } = ChannelNonNormalizedFloatingPointHandlingType.ReplaceWithZero;

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(DeviceDriver)}: {DeviceDriver}, {nameof(CaptureDiagnostics)}: {CaptureDiagnostics}, {nameof(OptimizationMethod)}: {OptimizationMethod}, {nameof(WriteOptimizationDutyCycle)}: {WriteOptimizationDutyCycle}, {nameof(NonNormalizedFloatingPointHandling)}: {NonNormalizedFloatingPointHandling}";
}