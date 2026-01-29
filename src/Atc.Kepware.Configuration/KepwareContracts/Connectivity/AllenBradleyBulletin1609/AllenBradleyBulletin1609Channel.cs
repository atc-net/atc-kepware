namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AllenBradleyBulletin1609;

/// <summary>
/// Channel properties for the Allen-Bradley Bulletin 1609 driver.
/// </summary>
internal sealed class AllenBradleyBulletin1609Channel : ChannelBase
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}