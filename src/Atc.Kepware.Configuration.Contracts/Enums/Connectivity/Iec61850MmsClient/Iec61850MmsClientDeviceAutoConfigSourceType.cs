namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.Iec61850MmsClient;

/// <summary>
/// Specifies the source for automatic device configuration.
/// </summary>
public enum Iec61850MmsClientDeviceAutoConfigSourceType
{
    /// <summary>
    /// Tags will be created using the online device self-description services.
    /// </summary>
    [Description("Device")]
    Device = 0,

    /// <summary>
    /// Tags will be created from the configured SCL file, and the Connection parameters will be imported.
    /// </summary>
    [Description("SCL File")]
    SclFile = 1,
}