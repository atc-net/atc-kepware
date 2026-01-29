namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.AutomationDirectEbc;

/// <summary>
/// Interface for AutomationDirect EBC channel.
/// </summary>
public interface IAutomationDirectEbcChannel : IChannelBase
{
    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    string? NetworkAdapter { get; set; }
}