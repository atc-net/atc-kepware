namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.SimaticTi505Ethernet;

/// <summary>
/// Simatic/TI 505 Ethernet bit order.
/// </summary>
public enum SimaticTi505EthernetBitOrder
{
    /// <summary>
    /// Bit 0/1 is MSB.
    /// </summary>
    [Description("Bit 0/1 is MSB")]
    Bit01IsMsb = 0,

    /// <summary>
    /// Bit 0/1 is LSB.
    /// </summary>
    [Description("Bit 0/1 is LSB")]
    Bit01IsLsb = 1,
}