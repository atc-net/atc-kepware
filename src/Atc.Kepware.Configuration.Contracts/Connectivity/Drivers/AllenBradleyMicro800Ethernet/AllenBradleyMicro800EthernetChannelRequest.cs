namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyMicro800Ethernet;

/// <summary>
/// Channel request properties for the Allen-Bradley Micro800 Ethernet driver.
/// </summary>
public sealed class AllenBradleyMicro800EthernetChannelRequest : ChannelRequestBase, IAllenBradleyMicro800EthernetChannelRequest
{
    public AllenBradleyMicro800EthernetChannelRequest()
        : base(DriverType.AllenBradleyMicro800Ethernet)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
