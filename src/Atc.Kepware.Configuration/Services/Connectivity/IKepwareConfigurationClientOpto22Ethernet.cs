// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles Opto 22 Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified Opto 22 Ethernet channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<Opto22EthernetChannel?>> GetOpto22EthernetChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Opto 22 Ethernet device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<Opto22EthernetDevice?>> GetOpto22EthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Opto 22 Ethernet channel.
    /// </summary>
    /// <param name="request">The Opto 22 Ethernet Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateOpto22EthernetChannel(
        Opto22EthernetChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Opto 22 Ethernet device under the specified channel.
    /// </summary>
    /// <param name="request">The Opto 22 Ethernet Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateOpto22EthernetDevice(
        Opto22EthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}
