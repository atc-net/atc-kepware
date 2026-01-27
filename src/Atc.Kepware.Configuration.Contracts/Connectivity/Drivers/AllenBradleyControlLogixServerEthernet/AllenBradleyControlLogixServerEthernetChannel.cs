namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyControlLogixServerEthernet;

/// <summary>
/// Channel properties for the Allen-Bradley ControlLogix Server Ethernet driver.
/// </summary>
public sealed class AllenBradleyControlLogixServerEthernetChannel : ChannelBase, IAllenBradleyControlLogixServerEthernetChannel
{
    /// <inheritdoc />
    public int Port { get; set; } = 44818;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Port)}: {Port}";
}
