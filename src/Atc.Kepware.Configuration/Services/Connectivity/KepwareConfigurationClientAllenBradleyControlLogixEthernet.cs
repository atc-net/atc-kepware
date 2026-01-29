// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles Allen-Bradley ControlLogix Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<AllenBradleyControlLogixEthernetChannel?>> GetAllenBradleyControlLogixEthernetChannel(
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);

        var response = await Get<KepwareContracts.Connectivity.AllenBradleyControlLogixEthernet.AllenBradleyControlLogixEthernetChannel>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.DeviceDriver.Equals(DriverType.AllenBradleyControlLogixEthernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<AllenBradleyControlLogixEthernetChannel?>(HttpStatusCode.NotFound, data: null, $"Retrieved channel '{channelName}' is not a '{DriverType.AllenBradleyControlLogixEthernet.GetDescription()}' channel.");
        }

        return response.Adapt<HttpClientRequestResult<AllenBradleyControlLogixEthernetChannel?>>();
    }

    public async Task<HttpClientRequestResult<AllenBradleyControlLogixEthernetDevice?>> GetAllenBradleyControlLogixEthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<KepwareContracts.Connectivity.AllenBradleyControlLogixEthernet.AllenBradleyControlLogixEthernetDevice>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.Driver.Equals(DriverType.AllenBradleyControlLogixEthernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<AllenBradleyControlLogixEthernetDevice?>(HttpStatusCode.NotFound, data: null, $"Retrieved device '{deviceName}' is not a '{DriverType.AllenBradleyControlLogixEthernet.GetDescription()}' device.");
        }

        return response.Adapt<HttpClientRequestResult<AllenBradleyControlLogixEthernetDevice?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateAllenBradleyControlLogixEthernetChannel(
        AllenBradleyControlLogixEthernetChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateAllenBradleyControlLogixEthernetChannel(
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateAllenBradleyControlLogixEthernetDevice(
        AllenBradleyControlLogixEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateAllenBradleyControlLogixEthernetDevice(
            request,
            channelName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateAllenBradleyControlLogixEthernetChannel(
        AllenBradleyControlLogixEthernetChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.AllenBradleyControlLogixEthernet.AllenBradleyControlLogixEthernetChannelRequest>(),
            EndpointPathTemplateConstants.Channels,
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateAllenBradleyControlLogixEthernetDevice(
        AllenBradleyControlLogixEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.AllenBradleyControlLogixEthernet.AllenBradleyControlLogixEthernetDeviceRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}