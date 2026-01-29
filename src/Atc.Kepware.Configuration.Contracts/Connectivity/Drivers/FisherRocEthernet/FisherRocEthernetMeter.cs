namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.FisherRocEthernet;

/// <summary>
/// Represents a Fisher ROC Ethernet meter.
/// </summary>
public sealed class FisherRocEthernetMeter : MeterBase, IFisherRocEthernetMeter
{
    /// <inheritdoc />
    public bool NonMeterEvents { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NonMeterEvents)}: {NonMeterEvents}";
}
