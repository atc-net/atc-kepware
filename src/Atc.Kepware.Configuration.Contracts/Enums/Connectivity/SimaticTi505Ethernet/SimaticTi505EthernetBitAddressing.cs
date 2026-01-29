namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.SimaticTi505Ethernet;

/// <summary>
/// Simatic/TI 505 Ethernet 0/1-based bit addressing.
/// </summary>
public enum SimaticTi505EthernetBitAddressing
{
    /// <summary>
    /// 0-Based addressing.
    /// </summary>
    [Description("0-Based")]
    ZeroBased = 0,

    /// <summary>
    /// 1-Based addressing.
    /// </summary>
    [Description("1-Based")]
    OneBased = 1,
}