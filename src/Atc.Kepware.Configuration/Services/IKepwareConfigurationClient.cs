using Atc.Kepware.Configuration.Contracts.Drivers;

namespace Atc.Kepware.Configuration.Services;

public interface IKepwareConfigurationClient
{
    Task<(bool Succeeded, IList<ChannelBase>? Result, string? ErrorMessage)> GetChannels(
        CancellationToken cancellationToken = default);

    Task<(bool Succeeded, IList<DeviceBase>? Result, string? ErrorMessage)> GetDevices(
        string channelName,
        CancellationToken cancellationToken = default);

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