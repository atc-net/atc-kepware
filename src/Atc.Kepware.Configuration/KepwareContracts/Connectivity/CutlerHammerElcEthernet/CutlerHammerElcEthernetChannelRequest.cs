namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.CutlerHammerElcEthernet;

/// <summary>
/// Channel request properties for the Cutler-Hammer ELC Ethernet driver.
/// </summary>
internal sealed class CutlerHammerElcEthernetChannelRequest : ChannelRequestBase, ICutlerHammerElcEthernetChannelRequest
{
    public CutlerHammerElcEthernetChannelRequest()
        : base(DriverType.CutlerHammerElcEthernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}