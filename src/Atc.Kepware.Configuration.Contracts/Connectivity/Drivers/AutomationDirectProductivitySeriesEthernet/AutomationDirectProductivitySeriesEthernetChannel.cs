namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AutomationDirectProductivitySeriesEthernet;

/// <summary>
/// Represents an AutomationDirect Productivity Series Ethernet channel.
/// </summary>
public class AutomationDirectProductivitySeriesEthernetChannel : ChannelBase, IAutomationDirectProductivitySeriesEthernetChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
