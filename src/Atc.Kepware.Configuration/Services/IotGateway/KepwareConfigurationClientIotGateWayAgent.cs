// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles Iot Gateway calls for Agents and Iot Items.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    /// <summary>
    /// Check if an iot agent is defined by name.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name</param>
    /// <param name="cancellationToken">The CancellationToken</param>
    /// <returns>Returns <see langword="true"/> if <paramref name="iotAgentName"/> is found; otherwise, <see langword="false"/>.</returns>
    public async Task<HttpClientRequestResult<bool>> IsIotAgentDefined(
        string iotAgentName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);

        if (!IsValidIotGatewayName(
                iotAgentName,
                iotItemName: null,
                out var errorMessage))
        {
            return await Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(errorMessage!));
        }

        // It does not matter which path we set here (rest_clients//rest_servers//mqtt_clients) - the call still succeeds
        var response = await Get<KepwareContracts.IotGateway.IotAgentBase>(
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}",
            cancellationToken,
            shouldLogNotFound: false);

        if (!response.CommunicationSucceeded)
        {
            return new HttpClientRequestResult<bool>(new HttpRequestException("Communication error!"));
        }

        if (response.StatusCode is HttpStatusCode.OK or HttpStatusCode.NotFound)
        {
            return new HttpClientRequestResult<bool>(response.StatusCode, response.HasData);
        }

        return response.HasMessage
            ? new HttpClientRequestResult<bool>(response.StatusCode, response.HasData, response.Message!)
            : new HttpClientRequestResult<bool>(response.StatusCode, response.HasData);
    }

    /// <summary>
    /// Create an iot agent rest client.
    /// </summary>
    /// <param name="request">The request</param>
    /// <param name="cancellationToken">The CancellationToken</param>
    public Task<HttpClientRequestResult<bool>> CreateIotAgentRestClient(
        IotAgentRestClientRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateIotAgentRestClient(
            request,
            cancellationToken);
    }

    public async Task<HttpClientRequestResult<IList<IotAgentRestClient>?>> GetIotAgentRestClients(
        CancellationToken cancellationToken)
    {
        var response = await Get<IList<KepwareContracts.IotGateway.IotAgentRestClient>>(
            EndpointPathTemplateConstants.IotGatewayRestClients,
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<IList<IotAgentRestClient>?>>();
    }

    public async Task<HttpClientRequestResult<IotAgentRestClient?>> GetIotAgentRestClient(
        string iotAgentName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);

        var response = await Get<KepwareContracts.IotGateway.IotAgentRestClient>(
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}",
            cancellationToken);

        if (response.CommunicationSucceeded &&
            response.HasData &&
            !response.Data!.AgentType.Equals(IotAgentType.RestClient))
        {
            return new HttpClientRequestResult<IotAgentRestClient?>(HttpStatusCode.NotFound, data: null, $"Retrieved iot agent '{iotAgentName}' is not a '{IotAgentType.RestClient.GetDescription()}'.");
        }

        return response.Adapt<HttpClientRequestResult<IotAgentRestClient?>>();
    }

    public Task<HttpClientRequestResult<bool>> DeleteIotAgentRestClient(
        string iotAgentName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);

        return InvokeDeleteIotAgentRestClient(
            iotAgentName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateIotAgentRestClient(
        IotAgentRestClientRequest request,
        CancellationToken cancellationToken)
    {
        return Post(
            request.Adapt<KepwareContracts.IotGateway.IotAgentRestClientRequest>(),
            EndpointPathTemplateConstants.IotGatewayRestClients,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeDeleteIotAgentRestClient(
        string iotAgentName,
        CancellationToken cancellationToken)
        => Delete(
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}",
            cancellationToken);

    private static bool IsValidIotGatewayName(
        string clientName,
        string? iotItemName,
        out string? errorMessage)
    {
        if (!KeyStringAttribute.TryIsValid(clientName, out var errorMessageClient))
        {
            errorMessage = errorMessageClient;
            return false;
        }

        if (iotItemName is not null &&
            !KeyStringAttribute.TryIsValid(iotItemName, out var errorMessageIotItem))
        {
            errorMessage = errorMessageIotItem;
            return false;
        }

        errorMessage = null;
        return true;
    }
}