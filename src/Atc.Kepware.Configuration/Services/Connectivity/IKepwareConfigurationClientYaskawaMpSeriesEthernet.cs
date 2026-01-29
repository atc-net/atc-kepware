// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles Yaskawa MP Series Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified Yaskawa MP Series Ethernet channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<YaskawaMpSeriesEthernetChannel?>> GetYaskawaMpSeriesEthernetChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Yaskawa MP Series Ethernet device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<YaskawaMpSeriesEthernetDevice?>> GetYaskawaMpSeriesEthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Yaskawa MP Series Ethernet channel.
    /// </summary>
    /// <param name="request">The Yaskawa MP Series Ethernet Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateYaskawaMpSeriesEthernetChannel(
        YaskawaMpSeriesEthernetChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Yaskawa MP Series Ethernet device under the specified channel.
    /// </summary>
    /// <param name="request">The Yaskawa MP Series Ethernet Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateYaskawaMpSeriesEthernetDevice(
        YaskawaMpSeriesEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}