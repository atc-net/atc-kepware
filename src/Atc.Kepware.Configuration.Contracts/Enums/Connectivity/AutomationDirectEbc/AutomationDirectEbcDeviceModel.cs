namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.AutomationDirectEbc;

/// <summary>
/// AutomationDirect EBC device model types.
/// </summary>
public enum AutomationDirectEbcDeviceModel
{
    /// <summary>
    /// H2 model.
    /// </summary>
    [Description("H2")]
    H2 = 0,

    /// <summary>
    /// H4 model.
    /// </summary>
    [Description("H4")]
    H4 = 1,

    /// <summary>
    /// Terminator I/O model.
    /// </summary>
    [Description("Terminator I/O")]
    TerminatorIO = 2,

    /// <summary>
    /// GS1 Drive model.
    /// </summary>
    [Description("GS1 Drive")]
    Gs1Drive = 3,

    /// <summary>
    /// GS2 Drive model.
    /// </summary>
    [Description("GS2 Drive")]
    Gs2Drive = 4,

    /// <summary>
    /// DURApulse (GS3) Drive model.
    /// </summary>
    [Description("DURApulse (GS3) Drive")]
    DurapulseGs3Drive = 5,
}
