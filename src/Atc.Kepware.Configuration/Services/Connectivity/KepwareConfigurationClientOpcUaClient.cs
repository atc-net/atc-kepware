// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles OPC UA Client calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<OpcUaClientChannel?>> GetOpcUaClientChannel(
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);

        var response = await Get<KepwareContracts.Connectivity.OpcUaClient.OpcUaClientChannel>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}",
            cancellationToken);

        if (response.CommunicationSucceeded &&
            response.HasData &&
            !response.Data!.DeviceDriver.Equals(DriverType.OpcUaClient.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<OpcUaClientChannel?>(HttpStatusCode.NotFound, data: null, $"Retrieved channel '{channelName}' is not a '{DriverType.OpcUaClient.GetDescription()}' channel.");
        }

        return response.Adapt<HttpClientRequestResult<OpcUaClientChannel?>>();
    }

    public async Task<HttpClientRequestResult<OpcUaClientDevice?>> GetOpcUaClientDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<KepwareContracts.Connectivity.OpcUaClient.OpcUaClientDevice>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}",
            cancellationToken);

        if (response.CommunicationSucceeded &&
            response.HasData &&
            !response.Data!.Driver.Equals(DriverType.OpcUaClient.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<OpcUaClientDevice?>(HttpStatusCode.NotFound, data: null, $"Retrieved device '{deviceName}' is not a '{DriverType.OpcUaClient.GetDescription()}' device.");
        }

        return response.Adapt<HttpClientRequestResult<OpcUaClientDevice?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateOpcUaClientChannel(
        OpcUaClientChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateOpcUaChannel(
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateOpcUaClientDevice(
        OpcUaClientDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateOpcUaDevice(
            request,
            channelName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateOpcUaChannel(
        OpcUaClientChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.OpcUaClient.OpcUaClientChannelRequest>(),
            EndpointPathTemplateConstants.Channels,
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateOpcUaDevice(
        OpcUaClientDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.OpcUaClient.OpcUaClientDeviceRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}