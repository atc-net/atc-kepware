namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AllenBradleyBulletin1609;

/// <summary>
/// Channel request properties for the Allen-Bradley Bulletin 1609 driver.
/// </summary>
internal sealed class AllenBradleyBulletin1609ChannelRequest : ChannelRequestBase, IAllenBradleyBulletin1609ChannelRequest
{
    public AllenBradleyBulletin1609ChannelRequest()
        : base(DriverType.AllenBradleyBulletin1609)
    {
    }

    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
