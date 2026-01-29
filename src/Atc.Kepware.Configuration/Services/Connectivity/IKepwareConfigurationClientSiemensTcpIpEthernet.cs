// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles Siemens TCP/IP Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified Siemens TCP/IP Ethernet channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<SiemensTcpIpEthernetChannel?>> GetSiemensTcpIpEthernetChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Siemens TCP/IP Ethernet device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<SiemensTcpIpEthernetDevice?>> GetSiemensTcpIpEthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Siemens TCP/IP Ethernet channel.
    /// </summary>
    /// <param name="request">The Siemens TCP/IP Ethernet Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateSiemensTcpIpEthernetChannel(
        SiemensTcpIpEthernetChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Siemens TCP/IP Ethernet device under the specified channel.
    /// </summary>
    /// <param name="request">The Siemens TCP/IP Ethernet Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateSiemensTcpIpEthernetDevice(
        SiemensTcpIpEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}