namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SiemensTcpIpEthernet;

/// <summary>
/// Represents a Siemens TCP/IP Ethernet channel creation request.
/// </summary>
public class SiemensTcpIpEthernetChannelRequest : ChannelRequestBase, ISiemensTcpIpEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SiemensTcpIpEthernetChannelRequest"/> class.
    /// </summary>
    public SiemensTcpIpEthernetChannelRequest()
        : base(DriverType.SiemensTcpIpEthernet)
    {
    }

    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}