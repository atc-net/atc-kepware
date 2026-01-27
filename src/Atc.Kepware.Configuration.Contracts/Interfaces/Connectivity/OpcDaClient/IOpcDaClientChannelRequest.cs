namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.OpcDaClient;

/// <summary>
/// Defines the OPC DA Client channel request properties.
/// </summary>
public interface IOpcDaClientChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Gets or sets the Program ID of the OPC server to connect to.
    /// </summary>
    string ProgramId { get; set; }

    /// <summary>
    /// Gets or sets the name of the remote machine where the OPC server resides.
    /// </summary>
    /// <remarks>
    /// Leave blank if the server is on the same machine as the driver.
    /// </remarks>
    string? RemoteMachineName { get; set; }

    /// <summary>
    /// Gets or sets the connection type for local connections.
    /// </summary>
    OpcDaClientConnectionType ConnectionType { get; set; }

    /// <summary>
    /// Gets or sets the time in seconds between connection attempts.
    /// </summary>
    /// <remarks>
    /// Valid range: 5-600 seconds.
    /// </remarks>
    int FailedConnectionRetryInterval { get; set; }

    /// <summary>
    /// Gets or sets how often in seconds the driver tests the connection.
    /// </summary>
    /// <remarks>
    /// Valid range: 5-30 seconds.
    /// </remarks>
    int ServerStatusQueryInterval { get; set; }
}
