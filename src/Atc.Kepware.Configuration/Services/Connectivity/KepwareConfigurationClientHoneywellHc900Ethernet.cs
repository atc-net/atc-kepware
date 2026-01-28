// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles Honeywell HC900 Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<HoneywellHc900EthernetChannel?>> GetHoneywellHc900EthernetChannel(
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);

        var response = await Get<KepwareContracts.Connectivity.HoneywellHc900Ethernet.HoneywellHc900EthernetChannel>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.DeviceDriver.Equals(DriverType.HoneywellHc900Ethernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<HoneywellHc900EthernetChannel?>(HttpStatusCode.NotFound, data: null, $"Retrieved channel '{channelName}' is not a '{DriverType.HoneywellHc900Ethernet.GetDescription()}' channel.");
        }

        return response.Adapt<HttpClientRequestResult<HoneywellHc900EthernetChannel?>>();
    }

    public async Task<HttpClientRequestResult<HoneywellHc900EthernetDevice?>> GetHoneywellHc900EthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<KepwareContracts.Connectivity.HoneywellHc900Ethernet.HoneywellHc900EthernetDevice>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.Driver.Equals(DriverType.HoneywellHc900Ethernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<HoneywellHc900EthernetDevice?>(HttpStatusCode.NotFound, data: null, $"Retrieved device '{deviceName}' is not a '{DriverType.HoneywellHc900Ethernet.GetDescription()}' device.");
        }

        return response.Adapt<HttpClientRequestResult<HoneywellHc900EthernetDevice?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateHoneywellHc900EthernetChannel(
        HoneywellHc900EthernetChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateHoneywellHc900EthernetChannel(
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateHoneywellHc900EthernetDevice(
        HoneywellHc900EthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateHoneywellHc900EthernetDevice(
            request,
            channelName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateHoneywellHc900EthernetChannel(
        HoneywellHc900EthernetChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.HoneywellHc900Ethernet.HoneywellHc900EthernetChannelRequest>(),
            EndpointPathTemplateConstants.Channels,
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateHoneywellHc900EthernetDevice(
        HoneywellHc900EthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.HoneywellHc900Ethernet.HoneywellHc900EthernetDeviceRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}
