// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles Cutler-Hammer ELC Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<CutlerHammerElcEthernetChannel?>> GetCutlerHammerElcEthernetChannel(
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);

        var response = await Get<KepwareContracts.Connectivity.CutlerHammerElcEthernet.CutlerHammerElcEthernetChannel>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.DeviceDriver.Equals(DriverType.CutlerHammerElcEthernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<CutlerHammerElcEthernetChannel?>(HttpStatusCode.NotFound, data: null, $"Retrieved channel '{channelName}' is not a '{DriverType.CutlerHammerElcEthernet.GetDescription()}' channel.");
        }

        return response.Adapt<HttpClientRequestResult<CutlerHammerElcEthernetChannel?>>();
    }

    public async Task<HttpClientRequestResult<CutlerHammerElcEthernetDevice?>> GetCutlerHammerElcEthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<KepwareContracts.Connectivity.CutlerHammerElcEthernet.CutlerHammerElcEthernetDevice>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.Driver.Equals(DriverType.CutlerHammerElcEthernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<CutlerHammerElcEthernetDevice?>(HttpStatusCode.NotFound, data: null, $"Retrieved device '{deviceName}' is not a '{DriverType.CutlerHammerElcEthernet.GetDescription()}' device.");
        }

        return response.Adapt<HttpClientRequestResult<CutlerHammerElcEthernetDevice?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateCutlerHammerElcEthernetChannel(
        CutlerHammerElcEthernetChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateCutlerHammerElcEthernetChannel(
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateCutlerHammerElcEthernetDevice(
        CutlerHammerElcEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateCutlerHammerElcEthernetDevice(
            request,
            channelName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateCutlerHammerElcEthernetChannel(
        CutlerHammerElcEthernetChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.CutlerHammerElcEthernet.CutlerHammerElcEthernetChannelRequest>(),
            EndpointPathTemplateConstants.Channels,
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateCutlerHammerElcEthernetDevice(
        CutlerHammerElcEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.CutlerHammerElcEthernet.CutlerHammerElcEthernetDeviceRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}
