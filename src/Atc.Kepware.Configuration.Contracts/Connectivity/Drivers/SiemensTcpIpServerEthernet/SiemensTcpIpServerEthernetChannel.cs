namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SiemensTcpIpServerEthernet;

/// <summary>
/// Siemens TCP/IP Server Ethernet channel.
/// </summary>
public class SiemensTcpIpServerEthernetChannel : ChannelBase, ISiemensTcpIpServerEthernetChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public int PortNumber { get; set; } = 102;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}, {nameof(PortNumber)}: {PortNumber}";
}