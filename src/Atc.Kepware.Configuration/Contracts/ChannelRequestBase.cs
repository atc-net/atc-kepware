namespace Atc.Kepware.Configuration.Contracts;

public abstract class ChannelRequestBase : IChannelRequestBase
{
    protected ChannelRequestBase(DriverType deviceDriver)
    {
        DeviceDriver = deviceDriver.GetDescription();
    }

    /// <inheritdoc />
    [MinLength(1)]
    [MaxLength(256)]
    public string Name { get; set; } = string.Empty;

    /// <inheritdoc />
    [MaxLength(255)]
    public string Description { get; set; } = string.Empty;

    /// <inheritdoc />
    public string DeviceDriver { get; private init; }

    /// <inheritdoc />
    public bool? CaptureDiagnostics { get; set; }

    /// <inheritdoc />
    public ChannelOptimizationMethodType OptimizationMethod { get; set; } = ChannelOptimizationMethodType.WriteOnlyLatestValueForAllTags;

    /// <inheritdoc />
    [Range(1, 10)]
    public int WriteOptimizationDutyCycle { get; set; } = 10;

    /// <inheritdoc />
    public ChannelNonNormalizedFloatingPointHandlingType NonNormalizedFloatingPointHandling { get; set; } = ChannelNonNormalizedFloatingPointHandlingType.ReplaceWithZero;

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(DeviceDriver)}: {DeviceDriver}, {nameof(CaptureDiagnostics)}: {CaptureDiagnostics}, {nameof(OptimizationMethod)}: {OptimizationMethod}, {nameof(WriteOptimizationDutyCycle)}: {WriteOptimizationDutyCycle}, {nameof(NonNormalizedFloatingPointHandling)}: {NonNormalizedFloatingPointHandling}";
}