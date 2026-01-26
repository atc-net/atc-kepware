namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AllenBradleyControlLogixEthernet;

/// <summary>
/// Channel request properties for the Allen-Bradley ControlLogix Ethernet driver.
/// </summary>
internal sealed class AllenBradleyControlLogixEthernetChannelRequest : ChannelRequestBase, IAllenBradleyControlLogixEthernetChannelRequest
{
    public AllenBradleyControlLogixEthernetChannelRequest()
        : base(DriverType.AllenBradleyControlLogixEthernet)
    {
    }

    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
