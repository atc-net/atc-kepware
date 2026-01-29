// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles Allen-Bradley Server Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified Allen-Bradley Server Ethernet channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<AllenBradleyServerEthernetChannel?>> GetAllenBradleyServerEthernetChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Allen-Bradley Server Ethernet device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<AllenBradleyServerEthernetDevice?>> GetAllenBradleyServerEthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Allen-Bradley Server Ethernet channel.
    /// </summary>
    /// <param name="request">The Allen-Bradley Server Ethernet Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateAllenBradleyServerEthernetChannel(
        AllenBradleyServerEthernetChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Allen-Bradley Server Ethernet device under the specified channel.
    /// </summary>
    /// <param name="request">The Allen-Bradley Server Ethernet Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateAllenBradleyServerEthernetDevice(
        AllenBradleyServerEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}