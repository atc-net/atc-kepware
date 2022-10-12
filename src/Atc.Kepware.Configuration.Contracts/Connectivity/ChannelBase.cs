namespace Atc.Kepware.Configuration.Contracts.Connectivity;

public class ChannelBase : IChannelBase
{
    /// <inheritdoc />
    public string Name { get; set; } = string.Empty;

    /// <inheritdoc />
    public string Description { get; set; } = string.Empty;

    /// <inheritdoc />
    public string DeviceDriver { get; set; } = string.Empty;

    /// <inheritdoc />
    public bool? CaptureDiagnostics { get; set; }

    /// <inheritdoc />
    public int TagCount { get; set; }

    /// <inheritdoc />
    public ChannelOptimizationMethodType OptimizationMethod { get; set; }

    /// <inheritdoc />
    public int WriteOptimizationDutyCycle { get; set; }

    /// <inheritdoc />
    public ChannelNonNormalizedFloatingPointHandlingType NonNormalizedFloatingPointHandling { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(DeviceDriver)}: {DeviceDriver}, {nameof(CaptureDiagnostics)}: {CaptureDiagnostics}, {nameof(TagCount)}: {TagCount}, {nameof(OptimizationMethod)}: {OptimizationMethod}, {nameof(WriteOptimizationDutyCycle)}: {WriteOptimizationDutyCycle}, {nameof(NonNormalizedFloatingPointHandling)}: {NonNormalizedFloatingPointHandling}";
}