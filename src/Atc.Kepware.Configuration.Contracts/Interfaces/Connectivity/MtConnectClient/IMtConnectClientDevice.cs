namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.MtConnectClient;

/// <summary>
/// Device properties for the MTConnect Client driver.
/// </summary>
public interface IMtConnectClientDevice : IDeviceBase
{
    /// <summary>
    /// Gets or sets the port number.
    /// </summary>
    int PortNumber { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to close the socket connection with the agent after each read request.
    /// </summary>
    bool CloseAgentConnectionAfterEachRequest { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to validate tags via schema.
    /// </summary>
    bool SchemaTagValidation { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to read all items with one request.
    /// </summary>
    bool ReadAllItemsInSingleRequest { get; set; }

    /// <summary>
    /// Gets or sets the number of data items bundled together in each read request.
    /// </summary>
    int ItemsPerRequest { get; set; }
}