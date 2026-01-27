// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles Mitsubishi FX Net calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified Mitsubishi FX Net channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<MitsubishiFxNetChannel?>> GetMitsubishiFxNetChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Mitsubishi FX Net device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<MitsubishiFxNetDevice?>> GetMitsubishiFxNetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Mitsubishi FX Net channel.
    /// </summary>
    /// <param name="request">The Mitsubishi FX Net Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateMitsubishiFxNetChannel(
        MitsubishiFxNetChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Mitsubishi FX Net device under the specified channel.
    /// </summary>
    /// <param name="request">The Mitsubishi FX Net Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateMitsubishiFxNetDevice(
        MitsubishiFxNetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}
