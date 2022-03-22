namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles OPC UA calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public Task<(bool Succeeded, string? ErrorMessage)> CreateOpcUaChannel(
        OpcUaChannelRequest request,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(request);
        return InvokeCreateOpcUaChannel(
            request,
            cancellationToken);
    }

    public Task<(bool Succeeded, string? ErrorMessage)> CreateOpcUaDevice(
        OpcUaDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(request);
        return InvokeCreateOpcUaDevice(
            request,
            channelName,
            cancellationToken);
    }

    private Task<(bool Succeeded, string? ErrorMessage)> InvokeCreateOpcUaChannel(
        OpcUaChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request,
            EndpointPathTemplateConstants.ProjectChannels,
            cancellationToken);

    private Task<(bool Succeeded, string? ErrorMessage)> InvokeCreateOpcUaDevice(
        OpcUaDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request,
            $"{EndpointPathTemplateConstants.ProjectChannels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}