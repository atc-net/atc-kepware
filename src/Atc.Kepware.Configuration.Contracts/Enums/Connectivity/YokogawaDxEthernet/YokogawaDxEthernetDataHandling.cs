namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaDxEthernet;

/// <summary>
/// Yokogawa DX Ethernet data handling for out of range and error conditions.
/// </summary>
public enum YokogawaDxEthernetDataHandling
{
    [Description("None")]
    None = 0,

    [Description("+INF")]
    PlusInf = 1,

    [Description("-INF")]
    MinusInf = 2,
}