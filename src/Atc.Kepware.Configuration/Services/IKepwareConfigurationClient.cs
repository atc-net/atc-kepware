namespace Atc.Kepware.Configuration.Services;

public interface IKepwareConfigurationClient
{
    Task<bool> IsChannelDefined(
        string channelName,
        CancellationToken cancellationToken);

    Task<bool> IsDeviceDefined(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    Task<bool> IsTagDefined(
        string channelName,
        string deviceName,
        string tagName,
        string[] tagGroupStructure,
        CancellationToken cancellationToken);

    Task<bool> IsTagGroupDefined(
        string channelName,
        string deviceName,
        string tagGroupName,
        string[] tagGroupStructure,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<IList<ChannelBase>?>> GetChannels(
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<EuroMap63Channel?>> GetEuroMap63Channel(
        string channelName,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<OpcUaClientChannel?>> GetOpcUaClientChannel(
        string channelName,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<IList<DeviceBase>?>> GetDevices(
        string channelName,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<EuroMap63Device?>> GetEuroMap63Device(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<OpcUaClientDevice?>> GetOpcUaClientDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<TagRoot>> GetTags(
        string channelName,
        string deviceName,
        int maxDepth,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<IList<string>>> SearchTags(
        string? channelName,
        string? deviceName,
        string query,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<bool>> CreateTag(
        TagRequest request,
        string channelName,
        string deviceName,
        string[] tagGroupStructure,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<bool>> CreateTagGroup(
        TagGroupRequest request,
        string channelName,
        string deviceName,
        string[] tagGroupStructure,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<bool>> CreateEuroMap63Channel(
        Contracts.EuroMap63.EuroMap63ChannelRequest request,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<bool>> CreateEuroMap63Device(
        Contracts.EuroMap63.EuroMap63DeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<bool>> CreateOpcUaClientChannel(
        Contracts.OpcUaClient.OpcUaClientChannelRequest request,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<bool>> CreateOpcUaClientDevice(
        Contracts.OpcUaClient.OpcUaClientDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<bool>> DeleteChannel(
        string channelName,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<bool>> DeleteDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<bool>> DeleteTag(
        string channelName,
        string deviceName,
        string tagName,
        string[] tagGroupStructure,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<bool>> DeleteTagGroup(
        string channelName,
        string deviceName,
        string tagGroupName,
        string[] tagGroupStructure,
        CancellationToken cancellationToken);
}