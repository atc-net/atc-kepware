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

    Task<ResultResponse<IList<ChannelBase>?>> GetChannels(
        CancellationToken cancellationToken);

    Task<ResultResponse<IList<DeviceBase>?>> GetDevices(
        string channelName,
        CancellationToken cancellationToken);

    Task<ResultResponse<bool>> CreateEuroMap63Channel(
        Contracts.EuroMap63.EuroMap63ChannelRequest request,
        CancellationToken cancellationToken);

    Task<ResultResponse<bool>> CreateEuroMap63Device(
        Contracts.EuroMap63.EuroMap63DeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);

    Task<ResultResponse<bool>> CreateOpcUaClientChannel(
        Contracts.OpcUaClient.OpcUaClientChannelRequest request,
        CancellationToken cancellationToken);

    Task<ResultResponse<bool>> CreateOpcUaClientDevice(
        Contracts.OpcUaClient.OpcUaClientDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);

    Task<ResultResponse<bool>> DeleteChannel(
        string channelName,
        CancellationToken cancellationToken);

    Task<ResultResponse<bool>> DeleteDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);
}