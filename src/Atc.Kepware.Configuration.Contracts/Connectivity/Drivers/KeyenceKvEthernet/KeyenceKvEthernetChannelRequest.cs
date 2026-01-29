namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.KeyenceKvEthernet;

/// <summary>
/// Channel properties for the Keyence KV Ethernet driver.
/// </summary>
public sealed class KeyenceKvEthernetChannelRequest : ChannelRequestBase, IKeyenceKvEthernetChannelRequest
{
    public KeyenceKvEthernetChannelRequest()
        : base(DriverType.KeyenceKvEthernet)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}