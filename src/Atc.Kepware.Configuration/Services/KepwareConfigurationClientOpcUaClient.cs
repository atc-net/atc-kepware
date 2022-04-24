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
        var response = await Get<KepwareContracts.OpcUaClient.OpcUaClientChannel>(
            $"{EndpointPathTemplateConstants.ProjectChannels}/{channelName}",
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
        var response = await Get<KepwareContracts.OpcUaClient.OpcUaClientDevice>(
            $"{EndpointPathTemplateConstants.ProjectChannels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}",
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

        var validationErrorForName = KepwareConfigurationValidationHelper.GetErrorForName(request.Name);
        if (validationErrorForName is not null)
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrorForName));
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

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        var validationErrorForName = KepwareConfigurationValidationHelper.GetErrorForName(request.Name);
        if (validationErrorForName is not null)
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrorForName));
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
            request.Adapt<KepwareContracts.OpcUaClient.OpcUaClientChannelRequest>(),
            EndpointPathTemplateConstants.ProjectChannels,
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateOpcUaDevice(
        OpcUaClientDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.OpcUaClient.OpcUaClientDeviceRequest>(),
            $"{EndpointPathTemplateConstants.ProjectChannels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}