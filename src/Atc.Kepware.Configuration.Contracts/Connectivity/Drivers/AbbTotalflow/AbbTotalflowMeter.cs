namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AbbTotalflow;

/// <summary>
/// Represents an ABB Totalflow meter.
/// </summary>
public sealed class AbbTotalflowMeter : MeterBase, IAbbTotalflowMeter
{
    /// <inheritdoc />
    public AbbTotalflowMeterType MeterType { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(MeterType)}: {MeterType}";
}
