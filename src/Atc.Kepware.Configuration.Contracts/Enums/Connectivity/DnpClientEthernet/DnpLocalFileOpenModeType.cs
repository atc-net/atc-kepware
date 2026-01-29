namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.DnpClientEthernet;

/// <summary>
/// Specifies the way the local file should be opened during file transfers.
/// </summary>
public enum DnpLocalFileOpenModeType
{
    /// <summary>
    /// Overwrite - Replace the existing file.
    /// </summary>
    Overwrite = 0,

    /// <summary>
    /// Append - Add to the existing file.
    /// </summary>
    Append = 1,
}
