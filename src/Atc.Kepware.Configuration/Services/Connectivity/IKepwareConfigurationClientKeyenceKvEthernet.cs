// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles Keyence KV Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified Keyence KV Ethernet channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<KeyenceKvEthernetChannel?>> GetKeyenceKvEthernetChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Keyence KV Ethernet device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<KeyenceKvEthernetDevice?>> GetKeyenceKvEthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Keyence KV Ethernet channel.
    /// </summary>
    /// <param name="request">The Keyence KV Ethernet Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateKeyenceKvEthernetChannel(
        KeyenceKvEthernetChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Keyence KV Ethernet device under the specified channel.
    /// </summary>
    /// <param name="request">The Keyence KV Ethernet Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateKeyenceKvEthernetDevice(
        KeyenceKvEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}
