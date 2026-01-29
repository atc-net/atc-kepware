namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.KraussMaffeiMc4Ethernet;

/// <summary>
/// Channel properties for the KraussMaffei MC4 Ethernet driver.
/// </summary>
public sealed class KraussMaffeiMc4EthernetChannelRequest : ChannelRequestBase, IKraussMaffeiMc4EthernetChannelRequest
{
    public KraussMaffeiMc4EthernetChannelRequest()
        : base(DriverType.KraussMaffeiMc4Ethernet)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}