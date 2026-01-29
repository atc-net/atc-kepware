namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.Iec608705104Client;

/// <summary>
/// Specifies when the IEC 60870-5-104 client should perform initialization actions.
/// </summary>
public enum Iec608705104InitializationType
{
    /// <summary>
    /// No initialization action.
    /// </summary>
    None = 0,

    /// <summary>
    /// Perform action on connect/reconnect.
    /// </summary>
    ConnectReconnect = 1,

    /// <summary>
    /// Perform action at end of initialization.
    /// </summary>
    EndOfInitialization = 2,
}