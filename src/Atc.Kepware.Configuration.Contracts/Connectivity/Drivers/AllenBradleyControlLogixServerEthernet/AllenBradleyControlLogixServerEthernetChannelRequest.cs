namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyControlLogixServerEthernet;

/// <summary>
/// Channel request properties for the Allen-Bradley ControlLogix Server Ethernet driver.
/// </summary>
public sealed class AllenBradleyControlLogixServerEthernetChannelRequest : ChannelRequestBase, IAllenBradleyControlLogixServerEthernetChannelRequest
{
    public AllenBradleyControlLogixServerEthernetChannelRequest()
        : base(DriverType.AllenBradleyControlLogixServerEthernet)
    {
    }

    /// <inheritdoc />
    public int Port { get; set; } = 44818;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Port)}: {Port}";
}