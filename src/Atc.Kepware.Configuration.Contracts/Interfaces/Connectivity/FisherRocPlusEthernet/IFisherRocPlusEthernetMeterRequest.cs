namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.FisherRocPlusEthernet;

/// <summary>
/// Interface for Fisher ROC Plus Ethernet meter creation/update requests.
/// </summary>
public interface IFisherRocPlusEthernetMeterRequest : IMeterRequestBase
{
    /// <summary>
    /// Set to true to enable this meter to receive non-meter events.
    /// </summary>
    bool NonMeterEvents { get; set; }
}
