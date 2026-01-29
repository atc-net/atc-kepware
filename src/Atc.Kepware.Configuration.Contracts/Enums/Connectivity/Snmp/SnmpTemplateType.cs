namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.Snmp;

/// <summary>
/// SNMP device template type.
/// </summary>
/// <remarks>
/// Maps to Kepware property: snmp.DEVICE_TEMPLATE.
/// </remarks>
public enum SnmpTemplateType
{
    /// <summary>
    /// Ethernet Switch template.
    /// </summary>
    EthernetSwitch = 0,

    /// <summary>
    /// Single-phase UPS template.
    /// </summary>
    SinglePhaseUps = 1,

    /// <summary>
    /// Three-phase UPS template.
    /// </summary>
    ThreePhaseUps = 2,

    /// <summary>
    /// Other Device template.
    /// </summary>
    OtherDevice = 3,

    /// <summary>
    /// No template.
    /// </summary>
    None = 4,
}