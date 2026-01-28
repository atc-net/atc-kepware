// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles Alstom Redundant Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<AlstomRedundantEthernetChannel?>> GetAlstomRedundantEthernetChannel(
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);

        var response = await Get<KepwareContracts.Connectivity.AlstomRedundantEthernet.AlstomRedundantEthernetChannel>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.DeviceDriver.Equals(DriverType.AlstomRedundantEthernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<AlstomRedundantEthernetChannel?>(HttpStatusCode.NotFound, data: null, $"Retrieved channel '{channelName}' is not a '{DriverType.AlstomRedundantEthernet.GetDescription()}' channel.");
        }

        return response.Adapt<HttpClientRequestResult<AlstomRedundantEthernetChannel?>>();
    }

    public async Task<HttpClientRequestResult<AlstomRedundantEthernetDevice?>> GetAlstomRedundantEthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<KepwareContracts.Connectivity.AlstomRedundantEthernet.AlstomRedundantEthernetDevice>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.Driver.Equals(DriverType.AlstomRedundantEthernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<AlstomRedundantEthernetDevice?>(HttpStatusCode.NotFound, data: null, $"Retrieved device '{deviceName}' is not a '{DriverType.AlstomRedundantEthernet.GetDescription()}' device.");
        }

        return response.Adapt<HttpClientRequestResult<AlstomRedundantEthernetDevice?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateAlstomRedundantEthernetChannel(
        AlstomRedundantEthernetChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateAlstomRedundantEthernetChannel(
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateAlstomRedundantEthernetDevice(
        AlstomRedundantEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateAlstomRedundantEthernetDevice(
            request,
            channelName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateAlstomRedundantEthernetChannel(
        AlstomRedundantEthernetChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.AlstomRedundantEthernet.AlstomRedundantEthernetChannelRequest>(),
            EndpointPathTemplateConstants.Channels,
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateAlstomRedundantEthernetDevice(
        AlstomRedundantEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.AlstomRedundantEthernet.AlstomRedundantEthernetDeviceRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}
