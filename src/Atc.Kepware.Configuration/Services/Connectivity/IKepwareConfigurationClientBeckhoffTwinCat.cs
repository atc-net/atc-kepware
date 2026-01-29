// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles Beckhoff TwinCAT calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified Beckhoff TwinCAT channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<BeckhoffTwinCatChannel?>> GetBeckhoffTwinCatChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Beckhoff TwinCAT device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<BeckhoffTwinCatDevice?>> GetBeckhoffTwinCatDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Beckhoff TwinCAT channel.
    /// </summary>
    /// <param name="request">The Beckhoff TwinCAT Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateBeckhoffTwinCatChannel(
        BeckhoffTwinCatChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Beckhoff TwinCAT device under the specified channel.
    /// </summary>
    /// <param name="request">The Beckhoff TwinCAT Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateBeckhoffTwinCatDevice(
        BeckhoffTwinCatDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}