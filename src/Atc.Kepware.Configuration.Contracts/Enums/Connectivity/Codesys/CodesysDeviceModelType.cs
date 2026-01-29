namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.Codesys;

/// <summary>
/// Represents the device model types for CODESYS driver.
/// </summary>
public enum CodesysDeviceModelType
{
    /// <summary>
    /// CODESYS V2.3 Ethernet.
    /// </summary>
    [Description("CODESYS V2.3 Ethernet")]
    CodesysV23Ethernet = 0,

    /// <summary>
    /// CODESYS V3 Ethernet.
    /// </summary>
    [Description("CODESYS V3 Ethernet")]
    CodesysV3Ethernet = 1,
}