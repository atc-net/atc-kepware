namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles OPC UA calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public Task<HttpClientRequestResult<bool>> CreateOpcUaClientChannel(
        Contracts.OpcUaClient.OpcUaClientChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        return InvokeCreateOpcUaChannel(
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateOpcUaClientDevice(
        Contracts.OpcUaClient.OpcUaClientDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        return InvokeCreateOpcUaDevice(
            request,
            channelName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateOpcUaChannel(
        Contracts.OpcUaClient.OpcUaClientChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.OpcUaClient.OpcUaClientChannelRequest>(),
            EndpointPathTemplateConstants.ProjectChannels,
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateOpcUaDevice(
        Contracts.OpcUaClient.OpcUaClientDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.OpcUaClient.OpcUaClientDeviceRequest>(),
            $"{EndpointPathTemplateConstants.ProjectChannels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}