namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.MtConnectClient;

/// <summary>
/// Device request properties for the MTConnect Client driver.
/// </summary>
public interface IMtConnectClientDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the port number.
    /// </summary>
    /// <remarks>
    /// Valid range is 0-65535. Default is 80.
    /// </remarks>
    int PortNumber { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to close the socket connection with the agent after each read request.
    /// </summary>
    /// <remarks>
    /// Default is true.
    /// </remarks>
    bool CloseAgentConnectionAfterEachRequest { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to validate tags via schema.
    /// </summary>
    /// <remarks>
    /// Default is true.
    /// </remarks>
    bool SchemaTagValidation { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to read all items with one request.
    /// </summary>
    /// <remarks>
    /// Default is true. When false, the ItemsPerRequest property controls how many items are read per request.
    /// </remarks>
    bool ReadAllItemsInSingleRequest { get; set; }

    /// <summary>
    /// Gets or sets the number of data items bundled together in each read request.
    /// </summary>
    /// <remarks>
    /// Valid range is 1-100. Default is 25. Only applicable when ReadAllItemsInSingleRequest is false.
    /// </remarks>
    int ItemsPerRequest { get; set; }
}
