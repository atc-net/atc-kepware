namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.BristolBsapIp;

/// <summary>
/// Device model types for Bristol BSAP IP driver.
/// </summary>
public enum BristolBsapIpDeviceModelType
{
    /// <summary>
    /// DPC 33xx model.
    /// </summary>
    [Description("DPC 33xx")]
    Dpc33Xx = 0,

    /// <summary>
    /// ControlWave model.
    /// </summary>
    [Description("ControlWave")]
    ControlWave = 1,
}
