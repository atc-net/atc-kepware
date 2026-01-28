// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles Aromat Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified Aromat Ethernet channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<AromatEthernetChannel?>> GetAromatEthernetChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Aromat Ethernet device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<AromatEthernetDevice?>> GetAromatEthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Aromat Ethernet channel.
    /// </summary>
    /// <param name="request">The Aromat Ethernet Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateAromatEthernetChannel(
        AromatEthernetChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Aromat Ethernet device under the specified channel.
    /// </summary>
    /// <param name="request">The Aromat Ethernet Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateAromatEthernetDevice(
        AromatEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}
