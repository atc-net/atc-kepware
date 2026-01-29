namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.SixnetEthertrak;

/// <summary>
/// Channel properties for the SIXNET EtherTRAK driver.
/// </summary>
internal sealed class SixnetEthertrakChannel : ChannelBase, ISixnetEthertrakChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}