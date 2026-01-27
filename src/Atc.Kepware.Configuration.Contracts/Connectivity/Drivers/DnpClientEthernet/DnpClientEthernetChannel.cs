namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.DnpClientEthernet;

/// <summary>
/// Represents a DNP Client Ethernet channel.
/// </summary>
public class DnpClientEthernetChannel : ChannelBase, IDnpClientEthernetChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
