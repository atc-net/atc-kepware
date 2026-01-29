namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Opto22Ethernet;

/// <summary>
/// Channel properties for the Opto 22 Ethernet driver.
/// </summary>
public sealed class Opto22EthernetChannelRequest : ChannelRequestBase, IOpto22EthernetChannelRequest
{
    public Opto22EthernetChannelRequest()
        : base(DriverType.Opto22Ethernet)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}