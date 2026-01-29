// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles OPC XML-DA Client calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<OpcXmlDaClientChannel?>> GetOpcXmlDaClientChannel(
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);

        var response = await Get<KepwareContracts.Connectivity.OpcXmlDaClient.OpcXmlDaClientChannel>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.DeviceDriver.Equals(DriverType.OpcXmlDaClient.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<OpcXmlDaClientChannel?>(HttpStatusCode.NotFound, data: null, $"Retrieved channel '{channelName}' is not a '{DriverType.OpcXmlDaClient.GetDescription()}' channel.");
        }

        return response.Adapt<HttpClientRequestResult<OpcXmlDaClientChannel?>>();
    }

    public async Task<HttpClientRequestResult<OpcXmlDaClientDevice?>> GetOpcXmlDaClientDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<KepwareContracts.Connectivity.OpcXmlDaClient.OpcXmlDaClientDevice>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.Driver.Equals(DriverType.OpcXmlDaClient.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<OpcXmlDaClientDevice?>(HttpStatusCode.NotFound, data: null, $"Retrieved device '{deviceName}' is not a '{DriverType.OpcXmlDaClient.GetDescription()}' device.");
        }

        return response.Adapt<HttpClientRequestResult<OpcXmlDaClientDevice?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateOpcXmlDaClientChannel(
        OpcXmlDaClientChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateOpcXmlDaClientChannel(
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateOpcXmlDaClientDevice(
        OpcXmlDaClientDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateOpcXmlDaClientDevice(
            request,
            channelName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateOpcXmlDaClientChannel(
        OpcXmlDaClientChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.OpcXmlDaClient.OpcXmlDaClientChannelRequest>(),
            EndpointPathTemplateConstants.Channels,
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateOpcXmlDaClientDevice(
        OpcXmlDaClientDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.OpcXmlDaClient.OpcXmlDaClientDeviceRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}