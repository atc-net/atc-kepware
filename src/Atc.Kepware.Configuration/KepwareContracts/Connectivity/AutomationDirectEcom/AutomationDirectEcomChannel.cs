namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AutomationDirectEcom;

/// <summary>
/// Channel properties for the AutomationDirect ECOM driver.
/// </summary>
internal sealed class AutomationDirectEcomChannel : ChannelBase, IAutomationDirectEcomChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}