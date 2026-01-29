namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.OmronFinsEthernet;

/// <summary>
/// Specifies the behavior when making writes to Counter Status or Timer Status addresses in Run Mode.
/// </summary>
public enum OmronFinsEthernetCsTsWritesModeType
{
    /// <summary>
    /// Fail the write and log a message.
    /// </summary>
    FailWriteLogMessage = 0,

    /// <summary>
    /// Set the PLC to Monitor Mode, then perform the write.
    /// </summary>
    SetPlcToMonitorModePerformWrite = 1,

    /// <summary>
    /// Set the PLC to Monitor Mode, perform the write, then reset to Run Mode.
    /// </summary>
    SetPlcToMonitorModeWriteResetToRun = 2,
}