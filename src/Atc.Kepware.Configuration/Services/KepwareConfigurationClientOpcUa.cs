namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles OPC UA calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public Task<KepwareResultResponse<bool>> CreateOpcUaChannel(
        OpcUaChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        return InvokeCreateOpcUaChannel(
            request,
            cancellationToken);
    }

    public Task<KepwareResultResponse<bool>> CreateOpcUaDevice(
        OpcUaDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        return InvokeCreateOpcUaDevice(
            request,
            channelName,
            cancellationToken);
    }

    private Task<KepwareResultResponse<bool>> InvokeCreateOpcUaChannel(
        OpcUaChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request,
            EndpointPathTemplateConstants.ProjectChannels,
            cancellationToken);

    private Task<KepwareResultResponse<bool>> InvokeCreateOpcUaDevice(
        OpcUaDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request,
            $"{EndpointPathTemplateConstants.ProjectChannels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}