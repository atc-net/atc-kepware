namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SiemensTcpIpServerEthernet;

/// <summary>
/// Siemens TCP/IP Server Ethernet channel request.
/// </summary>
public class SiemensTcpIpServerEthernetChannelRequest : ChannelRequestBase, ISiemensTcpIpServerEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SiemensTcpIpServerEthernetChannelRequest"/> class.
    /// </summary>
    public SiemensTcpIpServerEthernetChannelRequest()
        : base(DriverType.SiemensTcpIpServerEthernet)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    [Range(0, 65535)]
    public int PortNumber { get; set; } = 102;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}, {nameof(PortNumber)}: {PortNumber}";
}