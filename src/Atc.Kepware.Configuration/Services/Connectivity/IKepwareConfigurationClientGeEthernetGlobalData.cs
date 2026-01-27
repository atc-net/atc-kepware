// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles GE Ethernet Global Data calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified GE Ethernet Global Data channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<GeEthernetGlobalDataChannel?>> GetGeEthernetGlobalDataChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified GE Ethernet Global Data device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<GeEthernetGlobalDataDevice?>> GetGeEthernetGlobalDataDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new GE Ethernet Global Data channel.
    /// </summary>
    /// <param name="request">The GE Ethernet Global Data Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateGeEthernetGlobalDataChannel(
        GeEthernetGlobalDataChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new GE Ethernet Global Data device under the specified channel.
    /// </summary>
    /// <param name="request">The GE Ethernet Global Data Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateGeEthernetGlobalDataDevice(
        GeEthernetGlobalDataDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}
