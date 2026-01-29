namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.KraussMaffeiMc4Ethernet;

/// <summary>
/// Specifies the request size operating mode for the KraussMaffei MC4 device.
/// In Standard Mode, up to 4 parameters per request can be sent.
/// In Extended Mode, up to 16 parameters per request can be sent.
/// </summary>
public enum KraussMaffeiMc4RequestSizeModeType
{
    /// <summary>
    /// Standard Mode - up to 4 parameters per request.
    /// </summary>
    StandardMode = 0,

    /// <summary>
    /// Extended Mode - up to 16 parameters per request.
    /// </summary>
    ExtendedMode = 1,
}