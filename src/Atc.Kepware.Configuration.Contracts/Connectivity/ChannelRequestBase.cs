namespace Atc.Kepware.Configuration.Contracts.Connectivity;

public abstract class ChannelRequestBase : IChannelRequestBase
{
    protected ChannelRequestBase(DriverType deviceDriver)
    {
        DeviceDriver = deviceDriver.GetDescription();
    }

    /// <inheritdoc />
    [KeyString]
    public string Name { get; set; } = string.Empty;

    /// <inheritdoc />
    [MaxLength(255)]
    public string Description { get; set; } = string.Empty;

    /// <inheritdoc />
    public string DeviceDriver { get; private set; }

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