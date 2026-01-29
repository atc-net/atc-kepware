namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.WagoEthernet;

/// <summary>
/// Specifies the device model type for Wago Ethernet devices.
/// </summary>
[SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "OK - By Design")]
public enum WagoEthernetDeviceModelType
{
    /// <summary>
    /// 750-342 model.
    /// </summary>
    [Description("750-342")]
    Model_750_342 = 0,

    /// <summary>
    /// 750-842 model.
    /// </summary>
    [Description("750-842")]
    Model_750_842 = 1,
}