// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles KraussMaffei MC4 Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified KraussMaffei MC4 Ethernet channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<KraussMaffeiMc4EthernetChannel?>> GetKraussMaffeiMc4EthernetChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified KraussMaffei MC4 Ethernet device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<KraussMaffeiMc4EthernetDevice?>> GetKraussMaffeiMc4EthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new KraussMaffei MC4 Ethernet channel.
    /// </summary>
    /// <param name="request">The KraussMaffei MC4 Ethernet Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateKraussMaffeiMc4EthernetChannel(
        KraussMaffeiMc4EthernetChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new KraussMaffei MC4 Ethernet device under the specified channel.
    /// </summary>
    /// <param name="request">The KraussMaffei MC4 Ethernet Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateKraussMaffeiMc4EthernetDevice(
        KraussMaffeiMc4EthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}