namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.OpcDaClient;

/// <summary>
/// Specifies the update mode for OPC DA Client devices.
/// </summary>
public enum OpcDaClientUpdateMode
{
    /// <summary>
    /// Exception mode - server notifies driver of data value and quality changes.
    /// </summary>
    Exception = 0,

    /// <summary>
    /// Poll mode - driver reads all items at the configured update/poll rate.
    /// </summary>
    Poll = 1,
}