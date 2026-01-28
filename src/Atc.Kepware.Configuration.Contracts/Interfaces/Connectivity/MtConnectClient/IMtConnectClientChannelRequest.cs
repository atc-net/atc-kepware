namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.MtConnectClient;

/// <summary>
/// Channel properties for the MTConnect Client driver.
/// </summary>
public interface IMtConnectClientChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Specify the URL or IP address of the MTConnect agent.
    /// </summary>
    string AgentUrl { get; set; }

    /// <summary>
    /// Specify the port number for the MTConnect agent connection.
    /// </summary>
    /// <remarks>
    /// Valid range is 1-65535. Default is 5000.
    /// </remarks>
    int Port { get; set; }

    /// <summary>
    /// Specify the HTTP timeout in milliseconds.
    /// </summary>
    /// <remarks>
    /// Valid range is 1000-30000. Default is 10000.
    /// </remarks>
    int HttpTimeout { get; set; }

    /// <summary>
    /// Specify the sample interval in milliseconds.
    /// </summary>
    /// <remarks>
    /// Valid range is 100-60000. Default is 1000.
    /// </remarks>
    int SampleInterval { get; set; }

    /// <summary>
    /// Specify the path for the probe request.
    /// </summary>
    string ProbePath { get; set; }

    /// <summary>
    /// Specify the path for the current request.
    /// </summary>
    string CurrentPath { get; set; }

    /// <summary>
    /// Specify the path for the sample request.
    /// </summary>
    string SamplePath { get; set; }
}
