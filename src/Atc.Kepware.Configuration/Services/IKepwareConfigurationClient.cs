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

    Task<KepwareResultResponse<IList<ChannelBase>?>> GetChannels(
        CancellationToken cancellationToken);

    Task<KepwareResultResponse<IList<DeviceBase>?>> GetDevices(
        string channelName,
        CancellationToken cancellationToken);

    Task<KepwareResultResponse<bool>> CreateEuroMap63Channel(
        EuroMap63ChannelRequest request,
        CancellationToken cancellationToken);

    Task<KepwareResultResponse<bool>> CreateEuroMap63Device(
        EuroMap63DeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);

    Task<KepwareResultResponse<bool>> CreateOpcUaChannel(
        OpcUaChannelRequest request,
        CancellationToken cancellationToken);

    Task<KepwareResultResponse<bool>> CreateOpcUaDevice(
        OpcUaDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);

    Task<KepwareResultResponse<bool>> DeleteChannel(
        string channelName,
        CancellationToken cancellationToken);

    Task<KepwareResultResponse<bool>> DeleteDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);
}