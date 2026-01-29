namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.OpcDaClient;

/// <summary>
/// Specifies the connection type for OPC DA Client channels.
/// </summary>
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "Values match Kepware API")]
public enum OpcDaClientConnectionType
{
    /// <summary>
    /// In-process connection.
    /// </summary>
    InProc = 1,

    /// <summary>
    /// Local server connection.
    /// </summary>
    Local = 4,

    /// <summary>
    /// Any available connection type.
    /// </summary>
    Any = 21,
}