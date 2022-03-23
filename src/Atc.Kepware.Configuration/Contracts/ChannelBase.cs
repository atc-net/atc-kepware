namespace Atc.Kepware.Configuration.Contracts;

public class ChannelBase
{
    /// <summary>
    /// Specify the identity of this object.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Provide a brief summary of this object or its use.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    public string DeviceDriver { get; set; } = string.Empty;

    /// <summary>
    /// Select whether or not to make the channel's diagnostic information available to an OPC application.
    /// </summary>
    public bool? CaptureDiagnostics { get; set; }

    /// <summary>
    /// The total number of user defined tags assigned to the channel and all of its devices.
    /// </summary>
    public int TagCount { get; set; }

    /// <summary>
    /// Choose how write data is passed to the underlying communications driver when more than one write exists in the write queue.
    /// </summary>
    public ChannelOptimizationMethodType OptimizationMethod { get; set; }

    /// <summary>
    /// Specify the ratio of write operations to read operations, based on one read per configurable number of writes.
    /// </summary>
    public int WriteOptimizationDutyCycle { get; set; }

    /// <summary>
    /// Choose how to send invalid floating-point numbers to the client.
    /// </summary>
    public ChannelNonNormalizedFloatingPointHandlingType NonNormalizedFloatingPointHandling { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(DeviceDriver)}: {DeviceDriver}, {nameof(CaptureDiagnostics)}: {CaptureDiagnostics}, {nameof(TagCount)}: {TagCount}, {nameof(OptimizationMethod)}: {OptimizationMethod}, {nameof(WriteOptimizationDutyCycle)}: {WriteOptimizationDutyCycle}, {nameof(NonNormalizedFloatingPointHandling)}: {NonNormalizedFloatingPointHandling}";
}