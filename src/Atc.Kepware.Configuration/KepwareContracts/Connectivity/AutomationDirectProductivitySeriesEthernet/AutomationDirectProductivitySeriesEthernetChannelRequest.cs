namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AutomationDirectProductivitySeriesEthernet;

/// <summary>
/// Channel request properties for the AutomationDirect Productivity Series Ethernet driver.
/// </summary>
internal sealed class AutomationDirectProductivitySeriesEthernetChannelRequest : ChannelRequestBase, IAutomationDirectProductivitySeriesEthernetChannelRequest
{
    public AutomationDirectProductivitySeriesEthernetChannelRequest()
        : base(DriverType.AutomationDirectProductivitySeriesEthernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
