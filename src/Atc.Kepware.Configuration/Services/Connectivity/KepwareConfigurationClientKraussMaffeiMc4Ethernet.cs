// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles KraussMaffei MC4 Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<KraussMaffeiMc4EthernetChannel?>> GetKraussMaffeiMc4EthernetChannel(
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);

        var response = await Get<KepwareContracts.Connectivity.KraussMaffeiMc4Ethernet.KraussMaffeiMc4EthernetChannel>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.DeviceDriver.Equals(DriverType.KraussMaffeiMc4Ethernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<KraussMaffeiMc4EthernetChannel?>(HttpStatusCode.NotFound, data: null, $"Retrieved channel '{channelName}' is not a '{DriverType.KraussMaffeiMc4Ethernet.GetDescription()}' channel.");
        }

        return response.Adapt<HttpClientRequestResult<KraussMaffeiMc4EthernetChannel?>>();
    }

    public async Task<HttpClientRequestResult<KraussMaffeiMc4EthernetDevice?>> GetKraussMaffeiMc4EthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<KepwareContracts.Connectivity.KraussMaffeiMc4Ethernet.KraussMaffeiMc4EthernetDevice>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.Driver.Equals(DriverType.KraussMaffeiMc4Ethernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<KraussMaffeiMc4EthernetDevice?>(HttpStatusCode.NotFound, data: null, $"Retrieved device '{deviceName}' is not a '{DriverType.KraussMaffeiMc4Ethernet.GetDescription()}' device.");
        }

        return response.Adapt<HttpClientRequestResult<KraussMaffeiMc4EthernetDevice?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateKraussMaffeiMc4EthernetChannel(
        KraussMaffeiMc4EthernetChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateKraussMaffeiMc4EthernetChannel(
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateKraussMaffeiMc4EthernetDevice(
        KraussMaffeiMc4EthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateKraussMaffeiMc4EthernetDevice(
            request,
            channelName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateKraussMaffeiMc4EthernetChannel(
        KraussMaffeiMc4EthernetChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.KraussMaffeiMc4Ethernet.KraussMaffeiMc4EthernetChannelRequest>(),
            EndpointPathTemplateConstants.Channels,
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateKraussMaffeiMc4EthernetDevice(
        KraussMaffeiMc4EthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.KraussMaffeiMc4Ethernet.KraussMaffeiMc4EthernetDeviceRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}
