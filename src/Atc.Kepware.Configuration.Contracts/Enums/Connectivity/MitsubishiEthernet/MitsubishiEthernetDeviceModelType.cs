namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.MitsubishiEthernet;

/// <summary>
/// Specifies the device model type for Mitsubishi Ethernet devices.
/// </summary>
public enum MitsubishiEthernetDeviceModelType
{
    /// <summary>
    /// A Series PLC.
    /// </summary>
    ASeries = 0,

    /// <summary>
    /// Q Series PLC.
    /// </summary>
    QSeries = 1,

    /// <summary>
    /// FX3U PLC.
    /// </summary>
    FX3U = 2,

    /// <summary>
    /// QnA Series PLC.
    /// </summary>
    QnASeries = 3,

    /// <summary>
    /// L Series PLC.
    /// </summary>
    LSeries = 4,

    /// <summary>
    /// iQ-F Series PLC.
    /// </summary>
    [Description("iQ-F Series")]
    IqFSeries = 5,

    /// <summary>
    /// iQ-R Series PLC.
    /// </summary>
    [Description("iQ-R Series")]
    IqRSeries = 6,
}
