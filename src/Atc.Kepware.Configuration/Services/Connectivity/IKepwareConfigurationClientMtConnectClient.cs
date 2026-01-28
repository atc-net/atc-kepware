// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles MTConnect Client calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified MTConnect Client channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<MtConnectClientChannel?>> GetMtConnectClientChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified MTConnect Client device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<MtConnectClientDevice?>> GetMtConnectClientDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new MTConnect Client channel.
    /// </summary>
    /// <param name="request">The MTConnect Client Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateMtConnectClientChannel(
        MtConnectClientChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new MTConnect Client device under the specified channel.
    /// </summary>
    /// <param name="request">The MTConnect Client Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateMtConnectClientDevice(
        MtConnectClientDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}
