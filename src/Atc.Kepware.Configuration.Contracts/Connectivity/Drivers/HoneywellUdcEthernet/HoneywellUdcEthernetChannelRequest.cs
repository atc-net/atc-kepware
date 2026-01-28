namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.HoneywellUdcEthernet;

/// <summary>
/// Channel request properties for the Honeywell UDC Ethernet driver.
/// </summary>
public sealed class HoneywellUdcEthernetChannelRequest : ChannelRequestBase, IHoneywellUdcEthernetChannelRequest
{
    public HoneywellUdcEthernetChannelRequest()
        : base(DriverType.HoneywellUdcEthernet)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
