namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SattBusEthernet;

/// <summary>
/// Represents a SattBus Ethernet channel.
/// </summary>
public class SattBusEthernetChannel : ChannelBase, ISattBusEthernetChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
