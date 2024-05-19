namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles Iot Gateway calls for Agents and Iot Items.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Check if an iot agent is defined by name.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    /// <returns>Returns <see langword="true"/> if <paramref name="iotAgentName"/> is found; otherwise, <see langword="false"/>.</returns>
    Task<HttpClientRequestResult<bool>> IsIotAgentDefined(
        string iotAgentName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns base properties of the specified iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    /// <remarks>
    /// Sub iot items will not be returned in this call.
    /// </remarks>
    Task<HttpClientRequestResult<IotAgentBase?>> GetIotAgentBase(
        string iotAgentName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Create an iot agent rest client to Kepware's Iot Gateway.
    /// </summary>
    /// <param name="request">The request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateIotAgentRestClient(
        IotAgentRestClientCreateRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of all rest client iot agents.
    /// </summary>
    /// <param name="cancellationToken">The CancellationToken.</param>
    /// <remarks>
    /// Sub iot items will not be returned in this call.
    /// </remarks>
    Task<HttpClientRequestResult<IList<IotAgentRestClient>?>> GetIotAgentRestClients(
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified rest client iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    /// <remarks>
    /// Sub iot items will not be returned in this call.
    /// </remarks>
    Task<HttpClientRequestResult<IotAgentRestClient?>> GetIotAgentRestClient(
        string iotAgentName,
        CancellationToken cancellationToken);

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
    Task<HttpClientRequestResult<bool>> UpdateIotAgentRestClient(
        string iotAgentName,
        IotAgentRestClientUpdateRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Deletes the specified rest client iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    /// <remarks>
    /// This will delete all child iot items as well.
    /// </remarks>
    Task<HttpClientRequestResult<bool>> DeleteIotAgentRestClient(
        string iotAgentName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Deletes the specified rest server iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> DeleteIotAgentRestServer(
        string iotAgentName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Enables the specified iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="projectId">The Iot Agent ProjectId.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    /// <remarks>
    /// Requires that the current ProjectId is sent alongside the request.
    /// Retrieve the client forehand to retrieve ProjectId.
    /// </remarks>
    Task<HttpClientRequestResult<bool>> EnableIotAgent(
        string iotAgentName,
        long projectId,
        CancellationToken cancellationToken);

    /// <summary>
    /// Disables the specified iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="projectId">The Iot Agent ProjectId.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    /// <remarks>
    /// Requires that the current ProjectId is sent alongside the request.
    /// Retrieve the client forehand to retrieve ProjectId.
    /// </remarks>
    Task<HttpClientRequestResult<bool>> DisableIotAgent(
        string iotAgentName,
        long projectId,
        CancellationToken cancellationToken);

    /// <summary>
    /// Add a iot item to the specified rest client iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="request">The request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateIotAgentRestClientIotItem(
        string iotAgentName,
        IotItemCreateRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns all iot items under a given iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<IList<IotItem>?>> GetIotAgentIotItems(
        string iotAgentName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified iot item under a given iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="iotItemName">The Iot Item Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    /// <remarks>
    /// The iotItemName needs to have all . replaced by _ in order to find the item.
    /// </remarks>
    Task<HttpClientRequestResult<IotItem?>> GetIotAgentIotItem(
        string iotAgentName,
        string iotItemName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Enables the specified iot item under a given iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="projectId">The Iot Agent ProjectId.</param>
    /// <param name="iotItemName">The Iot Item Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    /// <remarks>
    /// Requires that the current ProjectId is sent alongside the request.
    /// Retrieve the client forehand to retrieve ProjectId.
    /// </remarks>
    Task<HttpClientRequestResult<bool>> EnableIotAgentIotItem(
        string iotAgentName,
        long projectId,
        string iotItemName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Disables the specified iot item under a given iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="projectId">The Iot Agent ProjectId.</param>
    /// <param name="iotItemName">The Iot Item Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    /// <remarks>
    /// Requires that the current ProjectId is sent alongside the request.
    /// Retrieve the client forehand to retrieve ProjectId.
    /// </remarks>
    Task<HttpClientRequestResult<bool>> DisableIotAgentIotItem(
        string iotAgentName,
        long projectId,
        string iotItemName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Updates the specified iot item under a given iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="iotItemName">The Iot Item Name.</param>
    /// <param name="request">The request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    /// <remarks>
    /// Requires that the current ProjectId is sent in the request.
    /// Retrieve the client forehand to retrieve ProjectId.
    /// </remarks>
    Task<HttpClientRequestResult<bool>> UpdateIotAgentRestClientIotItem(
        string iotAgentName,
        string iotItemName,
        IotItemUpdateRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Deletes the specified iot item under a given iot agent.
    /// </summary>
    /// <param name="iotAgentName">The Iot Agent Name.</param>
    /// <param name="iotItemName">The Iot Item Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    /// <remarks>
    /// The iotItemName needs to have all . replaced by _ in order to find the item.
    /// </remarks>
    Task<HttpClientRequestResult<bool>> DeleteIotAgentIotItem(
        string iotAgentName,
        string iotItemName,
        CancellationToken cancellationToken);
}