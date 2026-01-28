namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.Codesys;

/// <summary>
/// Represents the address type for CODESYS V3 devices.
/// </summary>
public enum CodesysDeviceAddressType
{
    /// <summary>
    /// IP/Port address type.
    /// </summary>
    [Description("IP/Port")]
    IpPort = 0,

    /// <summary>
    /// Logical Address/PLC Name address type.
    /// </summary>
    [Description("Logical Address/PLC Name")]
    LogicalAddressPlcName = 1,
}
