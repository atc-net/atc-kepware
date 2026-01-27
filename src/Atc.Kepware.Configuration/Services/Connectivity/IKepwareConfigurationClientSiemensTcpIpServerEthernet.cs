// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles Siemens TCP/IP Server Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified Siemens TCP/IP Server Ethernet channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<SiemensTcpIpServerEthernetChannel?>> GetSiemensTcpIpServerEthernetChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Siemens TCP/IP Server Ethernet device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<SiemensTcpIpServerEthernetDevice?>> GetSiemensTcpIpServerEthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Siemens TCP/IP Server Ethernet channel.
    /// </summary>
    /// <param name="request">The Siemens TCP/IP Server Ethernet Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateSiemensTcpIpServerEthernetChannel(
        SiemensTcpIpServerEthernetChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Siemens TCP/IP Server Ethernet device under the specified channel.
    /// </summary>
    /// <param name="request">The Siemens TCP/IP Server Ethernet Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateSiemensTcpIpServerEthernetDevice(
        SiemensTcpIpServerEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}
