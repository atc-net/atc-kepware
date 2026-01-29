namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AllenBradleyControlLogixServerEthernet;

/// <summary>
/// Channel properties for the Allen-Bradley ControlLogix Server Ethernet driver.
/// </summary>
internal sealed class AllenBradleyControlLogixServerEthernetChannel : ChannelBase, IAllenBradleyControlLogixServerEthernetChannel
{
    [JsonPropertyName("controllogix_unsolicited_ethernet.CHANNEL_PORT_NUMBER")]
    public int Port { get; set; } = 44818;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Port)}: {Port}";
}