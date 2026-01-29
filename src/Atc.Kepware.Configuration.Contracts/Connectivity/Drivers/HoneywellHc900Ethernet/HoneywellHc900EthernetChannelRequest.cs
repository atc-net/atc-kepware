namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.HoneywellHc900Ethernet;

/// <summary>
/// Channel properties for the Honeywell HC900 Ethernet driver.
/// </summary>
public sealed class HoneywellHc900EthernetChannelRequest : ChannelRequestBase, IHoneywellHc900EthernetChannelRequest
{
    public HoneywellHc900EthernetChannelRequest()
        : base(DriverType.HoneywellHc900Ethernet)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}