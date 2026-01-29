namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AutomationDirectEbc;

/// <summary>
/// AutomationDirect EBC channel request.
/// </summary>
internal sealed class AutomationDirectEbcChannelRequest : ChannelRequestBase, IAutomationDirectEbcChannelRequest
{
    public AutomationDirectEbcChannelRequest()
        : base(DriverType.AutomationDirectEbc)
    {
    }

    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}