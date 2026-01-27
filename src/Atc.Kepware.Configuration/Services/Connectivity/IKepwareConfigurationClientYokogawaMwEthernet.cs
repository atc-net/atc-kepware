// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles Yokogawa MW Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified Yokogawa MW Ethernet channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<YokogawaMwEthernetChannel?>> GetYokogawaMwEthernetChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Yokogawa MW Ethernet device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<YokogawaMwEthernetDevice?>> GetYokogawaMwEthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Yokogawa MW Ethernet channel.
    /// </summary>
    /// <param name="request">The Yokogawa MW Ethernet Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateYokogawaMwEthernetChannel(
        YokogawaMwEthernetChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Yokogawa MW Ethernet device under the specified channel.
    /// </summary>
    /// <param name="request">The Yokogawa MW Ethernet Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateYokogawaMwEthernetDevice(
        YokogawaMwEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}
