namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.Codesys;

/// <summary>
/// Represents where the driver should look for device symbols.
/// </summary>
public enum CodesysDeviceSymbolSourceType
{
    /// <summary>
    /// Load symbols from file.
    /// </summary>
    File = 0,

    /// <summary>
    /// Load symbols from device.
    /// </summary>
    Device = 1,

    /// <summary>
    /// Load symbols from device and cache.
    /// </summary>
    DeviceAndCache = 2,
}
