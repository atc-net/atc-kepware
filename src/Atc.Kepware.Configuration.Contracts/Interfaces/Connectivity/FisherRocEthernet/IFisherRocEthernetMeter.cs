namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.FisherRocEthernet;

/// <summary>
/// Interface for Fisher ROC Ethernet meter objects.
/// </summary>
public interface IFisherRocEthernetMeter : IMeterBase
{
    /// <summary>
    /// Indicates whether this meter receives non-meter events.
    /// </summary>
    bool NonMeterEvents { get; set; }
}
