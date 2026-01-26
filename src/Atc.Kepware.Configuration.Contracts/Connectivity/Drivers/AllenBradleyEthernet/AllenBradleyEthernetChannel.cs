namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyEthernet;

/// <summary>
/// Represents an Allen-Bradley Ethernet channel.
/// </summary>
public class AllenBradleyEthernetChannel : ChannelBase, IAllenBradleyEthernetChannel
{
    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}";
}
