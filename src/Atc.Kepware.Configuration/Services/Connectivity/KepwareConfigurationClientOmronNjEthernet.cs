// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles Omron NJ Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<OmronNjEthernetChannel?>> GetOmronNjEthernetChannel(
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);

        var response = await Get<KepwareContracts.Connectivity.OmronNjEthernet.OmronNjEthernetChannel>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.DeviceDriver.Equals(DriverType.OmronNjEthernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<OmronNjEthernetChannel?>(HttpStatusCode.NotFound, data: null, $"Retrieved channel '{channelName}' is not a '{DriverType.OmronNjEthernet.GetDescription()}' channel.");
        }

        return response.Adapt<HttpClientRequestResult<OmronNjEthernetChannel?>>();
    }

    public async Task<HttpClientRequestResult<OmronNjEthernetDevice?>> GetOmronNjEthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<KepwareContracts.Connectivity.OmronNjEthernet.OmronNjEthernetDevice>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.Driver.Equals(DriverType.OmronNjEthernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<OmronNjEthernetDevice?>(HttpStatusCode.NotFound, data: null, $"Retrieved device '{deviceName}' is not a '{DriverType.OmronNjEthernet.GetDescription()}' device.");
        }

        return response.Adapt<HttpClientRequestResult<OmronNjEthernetDevice?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateOmronNjEthernetChannel(
        OmronNjEthernetChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateOmronNjEthernetChannel(
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateOmronNjEthernetDevice(
        OmronNjEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateOmronNjEthernetDevice(
            request,
            channelName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateOmronNjEthernetChannel(
        OmronNjEthernetChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.OmronNjEthernet.OmronNjEthernetChannelRequest>(),
            EndpointPathTemplateConstants.Channels,
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateOmronNjEthernetDevice(
        OmronNjEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.OmronNjEthernet.OmronNjEthernetDeviceRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}
