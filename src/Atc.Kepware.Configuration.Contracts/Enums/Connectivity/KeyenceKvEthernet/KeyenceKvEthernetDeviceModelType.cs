namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.KeyenceKvEthernet;

/// <summary>
/// Keyence KV Ethernet device model types.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Keyence%20KV%20Ethernet/devices
/// Section: servermain.DEVICE_MODEL
/// </remarks>
public enum KeyenceKvEthernetDeviceModelType
{
    /// <summary>
    /// KV Series model.
    /// </summary>
    [Description("KV Series")]
    KvSeries = 0,
}
