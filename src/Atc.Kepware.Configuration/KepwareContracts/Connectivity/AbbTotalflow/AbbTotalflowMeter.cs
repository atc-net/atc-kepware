namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AbbTotalflow;

/// <summary>
/// Represents an ABB Totalflow meter with JSON serialization attributes.
/// </summary>
internal sealed class AbbTotalflowMeter : MeterBase, IAbbTotalflowMeter
{
    /// <inheritdoc />
    [JsonPropertyName("abb_totalflow.METER_TYPE")]
    public AbbTotalflowMeterType MeterType { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(MeterType)}: {MeterType}";
}