namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.DnpClientEthernet;

/// <summary>
/// Defines the DNP Client Ethernet channel request properties.
/// </summary>
public interface IDnpClientEthernetChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    string? NetworkAdapter { get; set; }

    /// <summary>
    /// Gets or sets the protocol for communicating with the DNP outstation.
    /// </summary>
    DnpClientEthernetProtocolType Protocol { get; set; }

    /// <summary>
    /// Gets or sets the source port for receiving UDP traffic.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-65535. Default: 0. Only used when Protocol is UDP.
    /// </remarks>
    int SourcePort { get; set; }

    /// <summary>
    /// Gets or sets the destination IP address or hostname.
    /// </summary>
    string? DestinationHost { get; set; }

    /// <summary>
    /// Gets or sets the destination port.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-65535. Default: 20000.
    /// </remarks>
    int DestinationPort { get; set; }

    /// <summary>
    /// Gets or sets the connection timeout in seconds.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-30. Default: 3.
    /// </remarks>
    int ConnectTimeout { get; set; }

    /// <summary>
    /// Gets or sets the response timeout in milliseconds.
    /// </summary>
    /// <remarks>
    /// Valid range: 100-3600000. Default: 10000.
    /// </remarks>
    int ResponseTimeout { get; set; }

    /// <summary>
    /// Gets or sets the maximum link layer retries.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-255. Default: 3.
    /// </remarks>
    int MaxLinkLayerRetries { get; set; }
}