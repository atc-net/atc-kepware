namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.ToyopucEthernet;

/// <summary>
/// Specifies the device model type for Toyopuc Ethernet devices.
/// </summary>
[SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "OK - By Design")]
public enum ToyopucEthernetDeviceModelType
{
    /// <summary>
    /// PC2/PC2 Interchange model.
    /// </summary>
    [Description("PC2/PC2 Interchange")]
    Pc2_Pc2Interchange = 0,

    /// <summary>
    /// PC3 Device model.
    /// </summary>
    [Description("PC3 Device")]
    Pc3Device = 1,

    /// <summary>
    /// PC10G Device model.
    /// </summary>
    [Description("PC10G Device")]
    Pc10GDevice = 2,
}
