namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles EuroMap 63 calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public Task<ResultResponse<bool>> CreateEuroMap63Channel(
        Contracts.EuroMap63.EuroMap63ChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        return InvokeCreateEuroMap63Channel(
            request,
            cancellationToken);
    }

    public Task<ResultResponse<bool>> CreateEuroMap63Device(
        Contracts.EuroMap63.EuroMap63DeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        return InvokeCreateEuroMap63Device(
            request,
            channelName,
            cancellationToken);
    }

    private Task<ResultResponse<bool>> InvokeCreateEuroMap63Channel(
        Contracts.EuroMap63.EuroMap63ChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.EuroMap63.EuroMap63ChannelRequest>(),
            EndpointPathTemplateConstants.ProjectChannels,
            cancellationToken);

    private Task<ResultResponse<bool>> InvokeCreateEuroMap63Device(
        Contracts.EuroMap63.EuroMap63DeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.EuroMap63.EuroMap63DeviceRequest>(),
            $"{EndpointPathTemplateConstants.ProjectChannels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}