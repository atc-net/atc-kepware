namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AutomationDirectEcom;

/// <summary>
/// Channel request properties for the AutomationDirect ECOM driver.
/// </summary>
internal sealed class AutomationDirectEcomChannelRequest : ChannelRequestBase, IAutomationDirectEcomChannelRequest
{
    public AutomationDirectEcomChannelRequest()
        : base(DriverType.AutomationDirectEcom)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
