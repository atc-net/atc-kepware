namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SiemensTcpIpEthernet;

/// <summary>
/// Represents a Siemens TCP/IP Ethernet channel.
/// </summary>
public class SiemensTcpIpEthernetChannel : ChannelBase, ISiemensTcpIpEthernetChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}