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
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
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
    /// Returns base properties of the specified iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    /// <remarks>
    /// Sub iot items will not be returned in this call.
    /// </remarks>
    public async Task<HttpClientRequestResult<IotAgentBase?>> GetIotAgentBase(
        string iotAgentName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);

        if (!IsValidIotGatewayName(
                iotAgentName,
                iotItemName: null,
                out var errorMessage))
        {
            return await Task.FromResult(HttpClientRequestResultFactory<IotAgentBase>.CreateBadRequest(errorMessage!));
        }

        // It does not matter which path we set here (rest_clients//rest_servers//mqtt_clients) - the call still succeeds
        var response = await Get<KepwareContracts.IotGateway.IotAgentBase>(
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}",
            cancellationToken,
            shouldLogNotFound: false);

        if (!response.CommunicationSucceeded)
        {
            return new HttpClientRequestResult<IotAgentBase?>(new HttpRequestException("Communication error!"));
        }

        return response.HasData
            ? response.Adapt<HttpClientRequestResult<IotAgentBase?>>()
            : new HttpClientRequestResult<IotAgentBase?>(response.StatusCode, null);
    }

    /// <summary>
    /// Create an iot agent rest client to Kepware's Iot Gateway.
    /// </summary>
    /// <param name="request">The request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    public Task<HttpClientRequestResult<bool>> CreateIotAgentRestClient(
        IotAgentRestClientCreateRequest request,
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

    /// <summary>
    /// Returns the properties of all rest client iot agents.
    /// </summary>
    /// <param name="cancellationToken">The CancellationToken.</param>
    /// <remarks>
    /// Sub iot items will not be returned in this call.
    /// </remarks>
    public async Task<HttpClientRequestResult<IList<IotAgentRestClient>?>> GetIotAgentRestClients(
        CancellationToken cancellationToken)
    {
        var response = await Get<IList<KepwareContracts.IotGateway.IotAgentRestClient>>(
            EndpointPathTemplateConstants.IotGatewayRestClients,
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<IList<IotAgentRestClient>?>>();
    }

    /// <summary>
    /// Returns the properties of the specified rest client iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    /// <remarks>
    /// Sub iot items will not be returned in this call.
    /// </remarks>
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

    /// <summary>
    /// Updates the specified rest client iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="request">The request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    /// <remarks>
    /// Requires that the current ProjectId is sent in the request.
    /// Retrieve the client forehand to retrieve ProjectId.
    /// </remarks>
    public Task<HttpClientRequestResult<bool>> UpdateIotAgentRestClient(
        string iotAgentName,
        IotAgentRestClientUpdateRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeUpdateIotAgentRestClient(
            iotAgentName,
            request,
            cancellationToken);
    }

    /// <summary>
    /// Deletes the specified rest client iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    /// <remarks>
    /// This will delete all child iot items as well.
    /// </remarks>
    public Task<HttpClientRequestResult<bool>> DeleteIotAgentRestClient(
        string iotAgentName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);

        return InvokeDeleteIotAgentRestClient(
            iotAgentName,
            cancellationToken);
    }

    /// <summary>
    /// Enables the specified iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="projectId">The Iot Agent ProjectId.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    /// <remarks>
    /// Requires that the current ProjectId is sent along side the request.
    /// Retrieve the client forehand to retrieve ProjectId.
    /// </remarks>
    public Task<HttpClientRequestResult<bool>> EnableIotAgent(
        string iotAgentName,
        long projectId,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);

        return InvokeEnableIotAgent(
            iotAgentName,
            projectId,
            cancellationToken);
    }

    /// <summary>
    /// Disables the specified iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="projectId">The Iot Agent ProjectId.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    /// <remarks>
    /// Requires that the current ProjectId is sent along side the request.
    /// Retrieve the client forehand to retrieve ProjectId.
    /// </remarks>
    public Task<HttpClientRequestResult<bool>> DisableIotAgent(
        string iotAgentName,
        long projectId,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);

        return InvokeDisableIotAgent(
            iotAgentName,
            projectId,
            cancellationToken);
    }

    /// <summary>
    /// Add a iot item to the specified rest client iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="request">The request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    public Task<HttpClientRequestResult<bool>> CreateIotAgentRestClientIotItem(
        string iotAgentName,
        IotItemRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);
        ArgumentNullException.ThrowIfNull(request);

        return InvokeCreateIotAgentRestClientIotItems(
            iotAgentName,
            request,
            cancellationToken);
    }

    /// <summary>
    /// Returns all iot items under a given iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    public async Task<HttpClientRequestResult<IList<IotItem>?>> GetIotAgentIotItems(
        string iotAgentName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);

        // It does not matter which path we set here (rest_clients//rest_servers//mqtt_clients) - the call still succeeds
        var response = await Get<IList<KepwareContracts.IotGateway.IotItem>>(
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}/{EndpointPathTemplateConstants.IotItems}",
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<IList<IotItem>?>>();
    }

    /// <summary>
    /// Returns the properties of the specified iot item under a given iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="iotItemName">The Iot Item Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    /// <remarks>
    /// The iotItemName needs to have all . replaced by _ in order to find the item.
    /// </remarks>
    public async Task<HttpClientRequestResult<IotItem?>> GetIotAgentIotItem(
        string iotAgentName,
        string iotItemName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);
        ArgumentNullException.ThrowIfNull(iotItemName);

        // It does not matter which path we set here (rest_clients//rest_servers//mqtt_clients) - the call still succeeds
        var response = await Get<KepwareContracts.IotGateway.IotItem>(
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}/{EndpointPathTemplateConstants.IotItems}/{iotItemName}",
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<IotItem?>>();
    }

    /// <summary>
    /// Deletes the specified iot item under a given iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="iotItemName">The Iot Item Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    /// <remarks>
    /// The iotItemName needs to have all . replaced by _ in order to find the item.
    /// </remarks>
    public Task<HttpClientRequestResult<bool>> DeleteIotAgentIotItem(
        string iotAgentName,
        string iotItemName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);
        ArgumentNullException.ThrowIfNull(iotItemName);

        return InvokeDeleteIotAgentIotItem(
            iotAgentName,
            iotItemName,
            cancellationToken);
    }

    /// <summary>
    /// Enables the specified iot item under a given iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="projectId">The Iot Agent ProjectId.</param>
    /// <param name="iotItemName">The Iot Item Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    /// <remarks>
    /// Requires that the current ProjectId is sent along side the request.
    /// Retrieve the client forehand to retrieve ProjectId.
    /// </remarks>
    public Task<HttpClientRequestResult<bool>> EnableIotAgentIotItem(
        string iotAgentName,
        long projectId,
        string iotItemName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);
        ArgumentNullException.ThrowIfNull(projectId);
        ArgumentNullException.ThrowIfNull(iotItemName);

        return InvokeEnableIotAgentIotItem(
            iotAgentName,
            projectId,
            iotItemName,
            cancellationToken);
    }

    /// <summary>
    /// Disables the specified iot item under a given iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="projectId">The Iot Agent ProjectId.</param>
    /// <param name="iotItemName">The Iot Item Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    /// <remarks>
    /// Requires that the current ProjectId is sent along side the request.
    /// Retrieve the client forehand to retrieve ProjectId.
    /// </remarks>
    public Task<HttpClientRequestResult<bool>> DisableIotAgentIotItem(
        string iotAgentName,
        long projectId,
        string iotItemName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);
        ArgumentNullException.ThrowIfNull(projectId);
        ArgumentNullException.ThrowIfNull(iotItemName);

        return InvokeDisableIotAgentIotItem(
            iotAgentName,
            projectId,
            iotItemName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateIotAgentRestClient(
        IotAgentRestClientCreateRequest request,
        CancellationToken cancellationToken)
    {
        return Post(
            request.Adapt<KepwareContracts.IotGateway.IotAgentRestClientCreateRequest>(),
            EndpointPathTemplateConstants.IotGatewayRestClients,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeUpdateIotAgentRestClient(
        string iotAgentName,
        IotAgentRestClientUpdateRequest request,
        CancellationToken cancellationToken)
    {
        return Put(
            request.Adapt<KepwareContracts.IotGateway.IotAgentRestClientUpdateRequest>(),
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}",
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeDeleteIotAgentRestClient(
        string iotAgentName,
        CancellationToken cancellationToken)
        => Delete(
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}",
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeEnableIotAgent(
        string iotAgentName,
        long projectId,
        CancellationToken cancellationToken)
    {
        var request = new KepwareContracts.IotGateway.IotAgentEnableDisableRequest
        {
            ProjectId = projectId,
            Enabled = true,
        };

        return Put(
            request,
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}",
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeDisableIotAgent(
        string iotAgentName,
        long projectId,
        CancellationToken cancellationToken)
    {
        var request = new KepwareContracts.IotGateway.IotAgentEnableDisableRequest
        {
            ProjectId = projectId,
            Enabled = false,
        };

        return Put(
            request,
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}",
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateIotAgentRestClientIotItems(
        string iotAgentName,
        IotItemRequest request,
        CancellationToken cancellationToken)
    {
        var agentPath = $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}";
        var iotItemsPath = $"{agentPath}/{EndpointPathTemplateConstants.IotItems}";

        return Post(
            new List<KepwareContracts.IotGateway.IotItemRequest>
            {
                request.Adapt<KepwareContracts.IotGateway.IotItemRequest>(),
            },
            iotItemsPath,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeDeleteIotAgentIotItem(
        string iotAgentName,
        string iotItemName,
        CancellationToken cancellationToken)
        => Delete(
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}/{EndpointPathTemplateConstants.IotItems}/{iotItemName}", // It does not matter which path we set here (rest_clients//rest_servers//mqtt_clients) - the call still succeeds
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeEnableIotAgentIotItem(
        string iotAgentName,
        long projectId,
        string iotItemName,
        CancellationToken cancellationToken)
    {
        var request = new KepwareContracts.IotGateway.IotItemEnableDisableRequest
        {
            ProjectId = projectId,
            Enabled = true,
        };

        return Put(
            request,
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}/{EndpointPathTemplateConstants.IotItems}/{iotItemName}", // It does not matter which path we set here (rest_clients//rest_servers//mqtt_clients) - the call still succeeds
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeDisableIotAgentIotItem(
        string iotAgentName,
        long projectId,
        string iotItemName,
        CancellationToken cancellationToken)
    {
        var request = new KepwareContracts.IotGateway.IotItemEnableDisableRequest
        {
            ProjectId = projectId,
            Enabled = false,
        };

        return Put(
            request,
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}/{EndpointPathTemplateConstants.IotItems}/{iotItemName}", // It does not matter which path we set here (rest_clients//rest_servers//mqtt_clients) - the call still succeeds
            cancellationToken);
    }

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