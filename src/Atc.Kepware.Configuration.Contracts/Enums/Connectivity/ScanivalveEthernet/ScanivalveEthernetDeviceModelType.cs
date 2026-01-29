namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.ScanivalveEthernet;

/// <summary>
/// Device model types for Scanivalve Ethernet driver.
/// Section: servermain.DEVICE_MODEL
/// </summary>
public enum ScanivalveEthernetDeviceModelType
{
    /// <summary>
    /// DSA3200 model.
    /// </summary>
    [Description("DSA3200")]
    Dsa3200 = 0,

    /// <summary>
    /// DTS3250 model.
    /// </summary>
    [Description("DTS3250")]
    Dts3250 = 1,
}