namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.BeckhoffTwinCat;

/// <summary>
/// Channel properties for the Beckhoff TwinCAT driver.
/// </summary>
internal sealed class BeckhoffTwinCatChannel : ChannelBase, IBeckhoffTwinCatChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
