namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AutomationDirectEbc;

/// <summary>
/// AutomationDirect EBC channel - Kepware format.
/// </summary>
internal sealed class AutomationDirectEbcChannel : ChannelBase, IAutomationDirectEbcChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}