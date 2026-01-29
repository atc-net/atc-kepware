// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles IEC 60870-5-104 Client calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified IEC 60870-5-104 Client channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<Iec608705104ClientChannel?>> GetIec608705104ClientChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified IEC 60870-5-104 Client device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<Iec608705104ClientDevice?>> GetIec608705104ClientDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new IEC 60870-5-104 Client channel.
    /// </summary>
    /// <param name="request">The IEC 60870-5-104 Client Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateIec608705104ClientChannel(
        Iec608705104ClientChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new IEC 60870-5-104 Client device under the specified channel.
    /// </summary>
    /// <param name="request">The IEC 60870-5-104 Client Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateIec608705104ClientDevice(
        Iec608705104ClientDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}