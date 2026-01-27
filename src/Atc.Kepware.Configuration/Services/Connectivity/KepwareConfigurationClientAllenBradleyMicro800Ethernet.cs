// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles Allen-Bradley Micro800 Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<AllenBradleyMicro800EthernetChannel?>> GetAllenBradleyMicro800EthernetChannel(
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);

        var response = await Get<KepwareContracts.Connectivity.AllenBradleyMicro800Ethernet.AllenBradleyMicro800EthernetChannel>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.DeviceDriver.Equals(DriverType.AllenBradleyMicro800Ethernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<AllenBradleyMicro800EthernetChannel?>(HttpStatusCode.NotFound, data: null, $"Retrieved channel '{channelName}' is not a '{DriverType.AllenBradleyMicro800Ethernet.GetDescription()}' channel.");
        }

        return response.Adapt<HttpClientRequestResult<AllenBradleyMicro800EthernetChannel?>>();
    }

    public async Task<HttpClientRequestResult<AllenBradleyMicro800EthernetDevice?>> GetAllenBradleyMicro800EthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<KepwareContracts.Connectivity.AllenBradleyMicro800Ethernet.AllenBradleyMicro800EthernetDevice>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.Driver.Equals(DriverType.AllenBradleyMicro800Ethernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<AllenBradleyMicro800EthernetDevice?>(HttpStatusCode.NotFound, data: null, $"Retrieved device '{deviceName}' is not a '{DriverType.AllenBradleyMicro800Ethernet.GetDescription()}' device.");
        }

        return response.Adapt<HttpClientRequestResult<AllenBradleyMicro800EthernetDevice?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateAllenBradleyMicro800EthernetChannel(
        AllenBradleyMicro800EthernetChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateAllenBradleyMicro800EthernetChannel(
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateAllenBradleyMicro800EthernetDevice(
        AllenBradleyMicro800EthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateAllenBradleyMicro800EthernetDevice(
            request,
            channelName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateAllenBradleyMicro800EthernetChannel(
        AllenBradleyMicro800EthernetChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.AllenBradleyMicro800Ethernet.AllenBradleyMicro800EthernetChannelRequest>(),
            EndpointPathTemplateConstants.Channels,
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateAllenBradleyMicro800EthernetDevice(
        AllenBradleyMicro800EthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.AllenBradleyMicro800Ethernet.AllenBradleyMicro800EthernetDeviceRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}
