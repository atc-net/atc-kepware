namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.SiemensTcpIpEthernet;

/// <summary>
/// Channel request properties for the Siemens TCP/IP Ethernet driver.
/// </summary>
internal sealed class SiemensTcpIpEthernetChannelRequest : ChannelRequestBase, ISiemensTcpIpEthernetChannelRequest
{
    public SiemensTcpIpEthernetChannelRequest()
        : base(DriverType.SiemensTcpIpEthernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
