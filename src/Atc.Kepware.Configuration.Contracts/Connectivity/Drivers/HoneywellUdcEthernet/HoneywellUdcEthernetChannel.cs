namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.HoneywellUdcEthernet;

/// <summary>
/// Channel properties for the Honeywell UDC Ethernet driver.
/// </summary>
public sealed class HoneywellUdcEthernetChannel : ChannelBase, IHoneywellUdcEthernetChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
