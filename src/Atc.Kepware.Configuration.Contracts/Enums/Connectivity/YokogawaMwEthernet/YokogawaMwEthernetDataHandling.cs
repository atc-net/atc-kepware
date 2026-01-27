namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaMwEthernet;

/// <summary>
/// Yokogawa MW Ethernet data handling for out of range and error conditions.
/// </summary>
public enum YokogawaMwEthernetDataHandling
{
    [Description("None")]
    None = 0,

    [Description("+INF")]
    PlusInf = 1,

    [Description("-INF")]
    MinusInf = 2,
}
