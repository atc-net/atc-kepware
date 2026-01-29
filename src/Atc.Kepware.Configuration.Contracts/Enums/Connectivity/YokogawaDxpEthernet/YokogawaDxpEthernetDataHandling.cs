namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaDxpEthernet;

/// <summary>
/// Yokogawa DXP Ethernet data handling for out of range and error conditions.
/// </summary>
public enum YokogawaDxpEthernetDataHandling
{
    [Description("None")]
    None = 0,

    [Description("+INF")]
    PlusInf = 1,

    [Description("-INF")]
    MinusInf = 2,
}