// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles Allen-Bradley ControlLogix Server Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<AllenBradleyControlLogixServerEthernetChannel?>> GetAllenBradleyControlLogixServerEthernetChannel(
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);

        var response = await Get<KepwareContracts.Connectivity.AllenBradleyControlLogixServerEthernet.AllenBradleyControlLogixServerEthernetChannel>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.DeviceDriver.Equals(DriverType.AllenBradleyControlLogixServerEthernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<AllenBradleyControlLogixServerEthernetChannel?>(HttpStatusCode.NotFound, data: null, $"Retrieved channel '{channelName}' is not a '{DriverType.AllenBradleyControlLogixServerEthernet.GetDescription()}' channel.");
        }

        return response.Adapt<HttpClientRequestResult<AllenBradleyControlLogixServerEthernetChannel?>>();
    }

    public async Task<HttpClientRequestResult<AllenBradleyControlLogixServerEthernetDevice?>> GetAllenBradleyControlLogixServerEthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<KepwareContracts.Connectivity.AllenBradleyControlLogixServerEthernet.AllenBradleyControlLogixServerEthernetDevice>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.Driver.Equals(DriverType.AllenBradleyControlLogixServerEthernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<AllenBradleyControlLogixServerEthernetDevice?>(HttpStatusCode.NotFound, data: null, $"Retrieved device '{deviceName}' is not a '{DriverType.AllenBradleyControlLogixServerEthernet.GetDescription()}' device.");
        }

        return response.Adapt<HttpClientRequestResult<AllenBradleyControlLogixServerEthernetDevice?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateAllenBradleyControlLogixServerEthernetChannel(
        AllenBradleyControlLogixServerEthernetChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateAllenBradleyControlLogixServerEthernetChannel(
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateAllenBradleyControlLogixServerEthernetDevice(
        AllenBradleyControlLogixServerEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateAllenBradleyControlLogixServerEthernetDevice(
            request,
            channelName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateAllenBradleyControlLogixServerEthernetChannel(
        AllenBradleyControlLogixServerEthernetChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.AllenBradleyControlLogixServerEthernet.AllenBradleyControlLogixServerEthernetChannelRequest>(),
            EndpointPathTemplateConstants.Channels,
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateAllenBradleyControlLogixServerEthernetDevice(
        AllenBradleyControlLogixServerEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.AllenBradleyControlLogixServerEthernet.AllenBradleyControlLogixServerEthernetDeviceRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}