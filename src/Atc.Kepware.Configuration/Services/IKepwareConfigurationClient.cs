namespace Atc.Kepware.Configuration.Services;

public interface IKepwareConfigurationClient
{
    Task<bool> IsChannelDefined(
        string channelName,
        CancellationToken cancellationToken = default);

    Task<bool> IsDeviceDefined(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken = default);

    Task<KepwareResultResponse<IList<ChannelBase>?>> GetChannels(
        CancellationToken cancellationToken = default);

    Task<KepwareResultResponse<IList<DeviceBase>?>> GetDevices(
        string channelName,
        CancellationToken cancellationToken = default);

    Task<KepwareResultResponse<bool>> CreateEuroMap63Channel(
        EuroMap63ChannelRequest request,
        CancellationToken cancellationToken = default);

    Task<KepwareResultResponse<bool>> CreateEuroMap63Device(
        EuroMap63DeviceRequest request,
        string channelName,
        CancellationToken cancellationToken = default);

    Task<KepwareResultResponse<bool>> CreateOpcUaChannel(
        OpcUaChannelRequest request,
        CancellationToken cancellationToken = default);

    Task<KepwareResultResponse<bool>> CreateOpcUaDevice(
        OpcUaDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken = default);
}