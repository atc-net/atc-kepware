// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles SIXNET EtherTRAK calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified SIXNET EtherTRAK channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<SixnetEthertrakChannel?>> GetSixnetEthertrakChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified SIXNET EtherTRAK device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<SixnetEthertrakDevice?>> GetSixnetEthertrakDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new SIXNET EtherTRAK channel.
    /// </summary>
    /// <param name="request">The SIXNET EtherTRAK Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateSixnetEthertrakChannel(
        SixnetEthertrakChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new SIXNET EtherTRAK device under the specified channel.
    /// </summary>
    /// <param name="request">The SIXNET EtherTRAK Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateSixnetEthertrakDevice(
        SixnetEthertrakDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}