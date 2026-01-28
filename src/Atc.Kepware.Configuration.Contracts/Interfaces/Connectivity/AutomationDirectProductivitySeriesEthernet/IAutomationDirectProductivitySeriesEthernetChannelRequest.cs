namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.AutomationDirectProductivitySeriesEthernet;

/// <summary>
/// Defines the AutomationDirect Productivity Series Ethernet channel request properties.
/// </summary>
public interface IAutomationDirectProductivitySeriesEthernetChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    string? NetworkAdapter { get; set; }
}
