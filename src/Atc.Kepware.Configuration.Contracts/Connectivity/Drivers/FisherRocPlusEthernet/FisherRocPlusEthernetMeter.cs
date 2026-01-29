namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.FisherRocPlusEthernet;

/// <summary>
/// Represents a Fisher ROC Plus Ethernet meter.
/// </summary>
public sealed class FisherRocPlusEthernetMeter : MeterBase, IFisherRocPlusEthernetMeter
{
    /// <inheritdoc />
    public bool NonMeterEvents { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NonMeterEvents)}: {NonMeterEvents}";
}
