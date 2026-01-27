// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles Allen-Bradley Micro800 Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified Allen-Bradley Micro800 Ethernet channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<AllenBradleyMicro800EthernetChannel?>> GetAllenBradleyMicro800EthernetChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Allen-Bradley Micro800 Ethernet device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<AllenBradleyMicro800EthernetDevice?>> GetAllenBradleyMicro800EthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Allen-Bradley Micro800 Ethernet channel.
    /// </summary>
    /// <param name="request">The Allen-Bradley Micro800 Ethernet Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateAllenBradleyMicro800EthernetChannel(
        AllenBradleyMicro800EthernetChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Allen-Bradley Micro800 Ethernet device under the specified channel.
    /// </summary>
    /// <param name="request">The Allen-Bradley Micro800 Ethernet Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateAllenBradleyMicro800EthernetDevice(
        AllenBradleyMicro800EthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}
