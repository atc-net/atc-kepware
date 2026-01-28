namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.BeckhoffTwinCat;

/// <summary>
/// Channel request properties for the Beckhoff TwinCAT driver.
/// </summary>
internal sealed class BeckhoffTwinCatChannelRequest : ChannelRequestBase, IBeckhoffTwinCatChannelRequest
{
    public BeckhoffTwinCatChannelRequest()
        : base(DriverType.BeckhoffTwinCat)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
