namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AutomationDirectProductivitySeriesEthernet;

/// <summary>
/// Channel properties for the AutomationDirect Productivity Series Ethernet driver.
/// </summary>
internal sealed class AutomationDirectProductivitySeriesEthernetChannel : ChannelBase, IAutomationDirectProductivitySeriesEthernetChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
