namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.OpcDaClient;

/// <summary>
/// Specifies the read/write method for OPC DA Client devices.
/// </summary>
public enum OpcDaClientReadWriteMethod
{
    /// <summary>
    /// Asynchronous read/write operations.
    /// </summary>
    Asynchronous = 0,

    /// <summary>
    /// Synchronous read/write operations.
    /// </summary>
    Synchronous = 1,
}
