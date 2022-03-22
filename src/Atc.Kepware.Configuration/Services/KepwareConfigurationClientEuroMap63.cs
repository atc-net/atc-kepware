namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles EuroMap 63 calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public Task<(bool Succeeded, string? ErrorMessage)> CreateEuroMap63Channel(
        EuroMap63ChannelRequest request,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(request);
        return InvokeCreateEuroMap63Channel(
            request,
            cancellationToken);
    }

    public Task<(bool Succeeded, string? ErrorMessage)> CreateEuroMap63Device(
        EuroMap63DeviceRequest request,
        string channelName,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(request);
        return InvokeCreateEuroMap63Device(
            request,
            channelName,
            cancellationToken);
    }

    private Task<(bool Succeeded, string? ErrorMessage)> InvokeCreateEuroMap63Channel(
            EuroMap63ChannelRequest request,
            CancellationToken cancellationToken)
            => Post(
                request,
                EndpointPathTemplateConstants.ProjectChannels,
                cancellationToken);

    private Task<(bool Succeeded, string? ErrorMessage)> InvokeCreateEuroMap63Device(
        EuroMap63DeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request,
            $"{EndpointPathTemplateConstants.ProjectChannels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}