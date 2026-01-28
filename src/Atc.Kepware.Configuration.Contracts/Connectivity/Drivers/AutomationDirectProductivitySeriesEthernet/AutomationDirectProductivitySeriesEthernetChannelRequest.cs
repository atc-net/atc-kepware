namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AutomationDirectProductivitySeriesEthernet;

/// <summary>
/// Represents an AutomationDirect Productivity Series Ethernet channel creation request.
/// </summary>
public class AutomationDirectProductivitySeriesEthernetChannelRequest : ChannelRequestBase, IAutomationDirectProductivitySeriesEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AutomationDirectProductivitySeriesEthernetChannelRequest"/> class.
    /// </summary>
    public AutomationDirectProductivitySeriesEthernetChannelRequest()
        : base(DriverType.AutomationDirectProductivitySeriesEthernet)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
