namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.BuswareEthernet;

/// <summary>
/// Busware Ethernet device model types.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Busware%20Ethernet/devices
/// Section: servermain.DEVICE_MODEL
/// </remarks>
public enum BuswareEthernetDeviceModelType
{
    /// <summary>
    /// BUSWARE Ethernet model.
    /// </summary>
    [Description("BUSWARE Ethernet")]
    BuswareEthernet = 0,
}
