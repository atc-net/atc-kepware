namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.BacNetIp;

/// <summary>
/// Specifies the device discovery method for BACnet/IP devices.
/// </summary>
public enum BacNetIpDiscoveryMethodType
{
    /// <summary>
    /// Automatic discovery using Who-Is broadcast.
    /// </summary>
    Automatic = 0,

    /// <summary>
    /// Manual discovery using a specific IP address.
    /// </summary>
    Manual = 1,
}
