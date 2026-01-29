// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles Siemens S7 Plus Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<SiemensS7PlusEthernetChannel?>> GetSiemensS7PlusEthernetChannel(
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);

        var response = await Get<KepwareContracts.Connectivity.SiemensS7PlusEthernet.SiemensS7PlusEthernetChannel>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.DeviceDriver.Equals(DriverType.SiemensS7PlusEthernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<SiemensS7PlusEthernetChannel?>(HttpStatusCode.NotFound, data: null, $"Retrieved channel '{channelName}' is not a '{DriverType.SiemensS7PlusEthernet.GetDescription()}' channel.");
        }

        return response.Adapt<HttpClientRequestResult<SiemensS7PlusEthernetChannel?>>();
    }

    public async Task<HttpClientRequestResult<SiemensS7PlusEthernetDevice?>> GetSiemensS7PlusEthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<KepwareContracts.Connectivity.SiemensS7PlusEthernet.SiemensS7PlusEthernetDevice>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.Driver.Equals(DriverType.SiemensS7PlusEthernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<SiemensS7PlusEthernetDevice?>(HttpStatusCode.NotFound, data: null, $"Retrieved device '{deviceName}' is not a '{DriverType.SiemensS7PlusEthernet.GetDescription()}' device.");
        }

        return response.Adapt<HttpClientRequestResult<SiemensS7PlusEthernetDevice?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateSiemensS7PlusEthernetChannel(
        SiemensS7PlusEthernetChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateSiemensS7PlusEthernetChannel(
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateSiemensS7PlusEthernetDevice(
        SiemensS7PlusEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateSiemensS7PlusEthernetDevice(
            request,
            channelName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateSiemensS7PlusEthernetChannel(
        SiemensS7PlusEthernetChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.SiemensS7PlusEthernet.SiemensS7PlusEthernetChannelRequest>(),
            EndpointPathTemplateConstants.Channels,
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateSiemensS7PlusEthernetDevice(
        SiemensS7PlusEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.SiemensS7PlusEthernet.SiemensS7PlusEthernetDeviceRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}