// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles Honeywell HC900 Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified Honeywell HC900 Ethernet channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<HoneywellHc900EthernetChannel?>> GetHoneywellHc900EthernetChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Honeywell HC900 Ethernet device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<HoneywellHc900EthernetDevice?>> GetHoneywellHc900EthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Honeywell HC900 Ethernet channel.
    /// </summary>
    /// <param name="request">The Honeywell HC900 Ethernet Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateHoneywellHc900EthernetChannel(
        HoneywellHc900EthernetChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Honeywell HC900 Ethernet device under the specified channel.
    /// </summary>
    /// <param name="request">The Honeywell HC900 Ethernet Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateHoneywellHc900EthernetDevice(
        HoneywellHc900EthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}
