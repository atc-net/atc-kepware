namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.FisherRocEthernet;

/// <summary>
/// Represents a Fisher ROC Ethernet meter with JSON serialization attributes.
/// </summary>
internal sealed class FisherRocEthernetMeter : MeterBase, IFisherRocEthernetMeter
{
    /// <inheritdoc />
    [JsonPropertyName("fisher_roc_ethernet.METER_NON_METER_EVENTS")]
    public bool NonMeterEvents { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NonMeterEvents)}: {NonMeterEvents}";
}
