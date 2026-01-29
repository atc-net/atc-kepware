namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.FisherRocPlusEthernet;

/// <summary>
/// Represents a Fisher ROC Plus Ethernet meter with JSON serialization attributes.
/// </summary>
internal sealed class FisherRocPlusEthernetMeter : MeterBase, IFisherRocPlusEthernetMeter
{
    /// <inheritdoc />
    [JsonPropertyName("fisher_rocplus_ethernet.METER_NON_METER_EVENTS")]
    public bool NonMeterEvents { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NonMeterEvents)}: {NonMeterEvents}";
}