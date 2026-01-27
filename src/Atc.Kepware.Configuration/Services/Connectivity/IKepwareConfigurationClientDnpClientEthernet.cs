// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles DNP Client Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified DNP Client Ethernet channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<DnpClientEthernetChannel?>> GetDnpClientEthernetChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified DNP Client Ethernet device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<DnpClientEthernetDevice?>> GetDnpClientEthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new DNP Client Ethernet channel.
    /// </summary>
    /// <param name="request">The DNP Client Ethernet Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateDnpClientEthernetChannel(
        DnpClientEthernetChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new DNP Client Ethernet device under the specified channel.
    /// </summary>
    /// <param name="request">The DNP Client Ethernet Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateDnpClientEthernetDevice(
        DnpClientEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}
