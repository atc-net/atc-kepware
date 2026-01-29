namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaCxEthernet;

/// <summary>
/// Yokogawa CX Ethernet data handling for out of range and error conditions.
/// </summary>
public enum YokogawaCxEthernetDataHandling
{
    [Description("None")]
    None = 0,

    [Description("+INF")]
    PlusInf = 1,

    [Description("-INF")]
    MinusInf = 2,
}