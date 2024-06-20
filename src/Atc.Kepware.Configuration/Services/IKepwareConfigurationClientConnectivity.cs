namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles connectivity calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Check if a channel is defined by name.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> IsChannelDefined(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Check if a device is defined by name.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> IsDeviceDefined(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Check if a tag is defined by name.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="tagName">The Tag Name.</param>
    /// <param name="tagGroupStructure">The Tag Group Structure.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> IsTagDefined(
        string channelName,
        string deviceName,
        string tagName,
        string[] tagGroupStructure,
        CancellationToken cancellationToken);

    /// <summary>
    /// Check if a tag group is defined by name.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="tagGroupName">The Tag Group Name.</param>
    /// <param name="tagGroupStructure">The Tag Group Structure.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> IsTagGroupDefined(
        string channelName,
        string deviceName,
        string tagGroupName,
        string[] tagGroupStructure,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns a list of all channels.
    /// </summary>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<IList<ChannelBase>?>> GetChannels(
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified EuroMap63 channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<EuroMap63Channel?>> GetEuroMap63Channel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified OpcUaClient channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<OpcUaClientChannel?>> GetOpcUaClientChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Simulator channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<SimulatorChannel?>> GetSimulatorChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns a list of all devices under the specified channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<IList<DeviceBase>?>> GetDevicesByChannelName(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns a list of all devices under the specified channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    /// <typeparam name="TDevice">A driver specific <see cref="DeviceBase"/> implementation.</typeparam>
    Task<HttpClientRequestResult<IList<TDevice>?>> GetDevicesByChannelName<TDevice>(
        string channelName,
        CancellationToken cancellationToken)
        where TDevice : DeviceBase;

    /// <summary>
    /// Returns the properties of the specified EuroMap63 device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<EuroMap63Device?>> GetEuroMap63Device(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified OpcUaClient device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<OpcUaClientDevice?>> GetOpcUaClientDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Simulator device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<SimulatorDevice?>> GetSimulatorDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns a tree of all tags under the specified device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="maxDepth">The Maximum Depth.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<TagRoot>> GetTags(
        string channelName,
        string deviceName,
        int maxDepth,
        CancellationToken cancellationToken);

    /// <summary>
    /// Searches for tags that match the query.
    /// </summary>
    /// <param name="channelName">The Channel Name (optional).</param>
    /// <param name="deviceName">The Device Name (optional).</param>
    /// <param name="query">The Query.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<IList<string>>> SearchTags(
        string? channelName,
        string? deviceName,
        string query,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new tag under the specified device.
    /// </summary>
    /// <param name="request">The Tag Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="tagGroupStructure">The Tag Group Structure.</param>
    /// <param name="ensureTagGroupStructure">Whether to Ensure the Tag Group Structure.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateTag(
        TagRequest request,
        string channelName,
        string deviceName,
        string[] tagGroupStructure,
        bool ensureTagGroupStructure,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new tag group under the specified device.
    /// </summary>
    /// <param name="request">The Tag Group Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="tagGroupStructure">The Tag Group Structure.</param>
    /// <param name="ensureTagGroupStructure">Whether to Ensure the Tag Group Structure.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateTagGroup(
        TagGroupRequest request,
        string channelName,
        string deviceName,
        string[] tagGroupStructure,
        bool ensureTagGroupStructure,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new EuroMap63 channel.
    /// </summary>
    /// <param name="request">The EuroMap63 Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateEuroMap63Channel(
        EuroMap63ChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new EuroMap63 device under the specified channel.
    /// </summary>
    /// <param name="request">The EuroMap63 Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateEuroMap63Device(
        EuroMap63DeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new OpcUaClient channel.
    /// </summary>
    /// <param name="request">The OpcUaClient Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateOpcUaClientChannel(
        OpcUaClientChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new OpcUaClient device under the specified channel.
    /// </summary>
    /// <param name="request">The OpcUaClient Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateOpcUaClientDevice(
        OpcUaClientDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Simulator channel.
    /// </summary>
    /// <param name="request">The Simulator Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateSimulatorChannel(
        SimulatorChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Simulator device under the specified channel.
    /// </summary>
    /// <param name="request">The Simulator Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateSimulatorDevice(
        SimulatorDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Deletes the specified channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> DeleteChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Deletes the specified device under the given channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> DeleteDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Deletes the specified tag under the given device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="tagName">The Tag Name.</param>
    /// <param name="tagGroupStructure">The Tag Group Structure.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> DeleteTag(
        string channelName,
        string deviceName,
        string tagName,
        string[] tagGroupStructure,
        CancellationToken cancellationToken);

    /// <summary>
    /// Deletes the specified tag group under the given device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="tagGroupName">The Tag Group Name.</param>
    /// <param name="tagGroupStructure">The Tag Group Structure.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> DeleteTagGroup(
        string channelName,
        string deviceName,
        string tagGroupName,
        string[] tagGroupStructure,
        CancellationToken cancellationToken);
}