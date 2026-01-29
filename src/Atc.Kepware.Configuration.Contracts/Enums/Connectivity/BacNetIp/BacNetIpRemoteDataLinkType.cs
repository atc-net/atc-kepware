namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.BacNetIp;

/// <summary>
/// Specifies whether to use remote data link technology for BACnet/IP devices.
/// </summary>
/// <remarks>
/// When disabled, the driver automatically calculates the BACnet MAC for a BACnet/IP device.
/// When enabled, the driver uses a hex string in BACnet MAC.
/// </remarks>
public enum BacNetIpRemoteDataLinkType
{
    /// <summary>
    /// Disabled - automatically calculate BACnet MAC for BACnet/IP.
    /// </summary>
    Disabled = 0,

    /// <summary>
    /// Enabled - use hex string in BACnet MAC for remote data link technology.
    /// </summary>
    Enabled = 1,
}