// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles Yokogawa MX Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified Yokogawa MX Ethernet channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<YokogawaMxEthernetChannel?>> GetYokogawaMxEthernetChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Yokogawa MX Ethernet device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<YokogawaMxEthernetDevice?>> GetYokogawaMxEthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Yokogawa MX Ethernet channel.
    /// </summary>
    /// <param name="request">The Yokogawa MX Ethernet Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateYokogawaMxEthernetChannel(
        YokogawaMxEthernetChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Yokogawa MX Ethernet device under the specified channel.
    /// </summary>
    /// <param name="request">The Yokogawa MX Ethernet Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateYokogawaMxEthernetDevice(
        YokogawaMxEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}
