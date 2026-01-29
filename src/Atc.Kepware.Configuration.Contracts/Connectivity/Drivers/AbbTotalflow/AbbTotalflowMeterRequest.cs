namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AbbTotalflow;

/// <summary>
/// Request for creating or updating an ABB Totalflow meter.
/// </summary>
public sealed class AbbTotalflowMeterRequest : MeterRequestBase, IAbbTotalflowMeterRequest
{
    /// <inheritdoc />
    public AbbTotalflowMeterType MeterType { get; set; } = AbbTotalflowMeterType.Gas;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(MeterType)}: {MeterType}";
}
