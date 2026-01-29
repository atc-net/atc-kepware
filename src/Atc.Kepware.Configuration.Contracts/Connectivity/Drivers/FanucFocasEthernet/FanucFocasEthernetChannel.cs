namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.FanucFocasEthernet;

/// <summary>
/// Channel properties for the Fanuc Focas Ethernet driver.
/// </summary>
public sealed class FanucFocasEthernetChannel : ChannelBase, IFanucFocasEthernetChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}