namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.Iec61850MmsClient;

/// <summary>
/// Specifies the value of orCat when making a structured write to a control object.
/// </summary>
public enum Iec61850MmsClientDeviceOrCatType
{
    /// <summary>
    /// Not supported.
    /// </summary>
    [Description("not-supported")]
    NotSupported = 0,

    /// <summary>
    /// Bay control.
    /// </summary>
    [Description("bay-control")]
    BayControl = 1,

    /// <summary>
    /// Station control.
    /// </summary>
    [Description("station-control")]
    StationControl = 2,

    /// <summary>
    /// Remote control.
    /// </summary>
    [Description("remote-control")]
    RemoteControl = 3,

    /// <summary>
    /// Automatic bay.
    /// </summary>
    [Description("automatic-bay")]
    AutomaticBay = 4,

    /// <summary>
    /// Automatic station.
    /// </summary>
    [Description("automatic-station")]
    AutomaticStation = 5,

    /// <summary>
    /// Automatic remote.
    /// </summary>
    [Description("automatic-remote")]
    AutomaticRemote = 6,

    /// <summary>
    /// Maintenance.
    /// </summary>
    [Description("maintenance")]
    Maintenance = 7,

    /// <summary>
    /// Process.
    /// </summary>
    [Description("process")]
    Process = 8,
}
