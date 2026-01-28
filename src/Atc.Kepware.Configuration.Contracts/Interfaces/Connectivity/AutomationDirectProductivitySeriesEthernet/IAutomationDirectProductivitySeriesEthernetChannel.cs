namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.AutomationDirectProductivitySeriesEthernet;

/// <summary>
/// Defines the AutomationDirect Productivity Series Ethernet channel properties.
/// </summary>
public interface IAutomationDirectProductivitySeriesEthernetChannel : IChannelBase
{
    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    string? NetworkAdapter { get; set; }
}
