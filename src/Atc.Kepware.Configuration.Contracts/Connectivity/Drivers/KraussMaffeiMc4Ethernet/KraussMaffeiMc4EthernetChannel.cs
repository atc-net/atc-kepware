namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.KraussMaffeiMc4Ethernet;

/// <summary>
/// Channel properties for the KraussMaffei MC4 Ethernet driver.
/// </summary>
public sealed class KraussMaffeiMc4EthernetChannel : ChannelBase, IKraussMaffeiMc4EthernetChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}