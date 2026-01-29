namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.OpcXmlDaClient;

/// <summary>
/// Specifies the update mode for OPC XML-DA Client devices.
/// </summary>
public enum OpcXmlDaClientUpdateMode
{
    /// <summary>
    /// Exception mode - the driver creates a subscription to tags and receives updates from the server when the data changes.
    /// </summary>
    Exception = 0,

    /// <summary>
    /// Poll mode - polls the remote server for data at the rate specified by the Update/Poll Rate.
    /// </summary>
    Poll = 1,
}
