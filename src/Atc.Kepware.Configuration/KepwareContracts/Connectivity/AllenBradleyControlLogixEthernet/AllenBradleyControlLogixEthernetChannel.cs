namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AllenBradleyControlLogixEthernet;

/// <summary>
/// Channel properties for the Allen-Bradley ControlLogix Ethernet driver.
/// </summary>
internal sealed class AllenBradleyControlLogixEthernetChannel : ChannelBase, IAllenBradleyControlLogixEthernetChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}