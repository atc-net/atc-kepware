namespace Atc.Kepware.Configuration.Services;

public interface IKepwareConfigurationClient
{
    Task<(bool Succeeded, string? ErrorMessage)> CreateEuroMap63Channel(
        EuroMap63ChannelRequest request,
        CancellationToken cancellationToken = default);

    Task<(bool Succeeded, string? ErrorMessage)> CreateEuroMap63Device(
        EuroMap63DeviceRequest request,
        string channelName,
        CancellationToken cancellationToken = default);

    Task<(bool Succeeded, string? ErrorMessage)> CreateOpcUaChannel(
        OpcUaChannelRequest request,
        CancellationToken cancellationToken = default);

    Task<(bool Succeeded, string? ErrorMessage)> CreateOpcUaDevice(
        OpcUaDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken = default);
}