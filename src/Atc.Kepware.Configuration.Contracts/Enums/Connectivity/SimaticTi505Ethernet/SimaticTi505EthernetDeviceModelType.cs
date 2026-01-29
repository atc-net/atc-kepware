namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.SimaticTi505Ethernet;

/// <summary>
/// Simatic/TI 505 Ethernet device model types.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Simatic%2FTI%20505%20Ethernet/devices
/// Section: servermain.DEVICE_MODEL
/// </remarks>
public enum SimaticTi505EthernetDeviceModelType
{
    /// <summary>
    /// 505-CP2572 model.
    /// </summary>
    [Description("505-CP2572")]
    Model505Cp2572 = 0,

    /// <summary>
    /// 505-CP1434-TCP model.
    /// </summary>
    [Description("505-CP1434-TCP")]
    Model505Cp1434Tcp = 1,

    /// <summary>
    /// CP2572 model.
    /// </summary>
    [Description("CP2572")]
    Cp2572 = 2,

    /// <summary>
    /// CTI 2572 model.
    /// </summary>
    [Description("CTI 2572")]
    Cti2572 = 3,

    /// <summary>
    /// CTI 2572-A model.
    /// </summary>
    [Description("CTI 2572-A")]
    Cti2572A = 4,

    /// <summary>
    /// CTI 2500 Series model.
    /// </summary>
    [Description("CTI 2500 Series")]
    Cti2500Series = 5,
}