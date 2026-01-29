namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.SimaticTi505Ethernet;

/// <summary>
/// Simatic/TI 505 Ethernet 505 protocol.
/// </summary>
public enum SimaticTi505EthernetProtocol
{
    /// <summary>
    /// CAMP only.
    /// </summary>
    [Description("CAMP")]
    Camp = 0,

    /// <summary>
    /// CAMP Plus Packed Task Code.
    /// </summary>
    [Description("CAMP Plus Packed Task Code")]
    CampPlusPackedTaskCode = 1,
}