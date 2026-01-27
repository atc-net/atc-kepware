namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaMxEthernet;

/// <summary>
/// Yokogawa MX Ethernet data handling for out of range and error conditions.
/// </summary>
public enum YokogawaMxEthernetDataHandling
{
    [Description("None")]
    None = 0,

    [Description("+INF")]
    PlusInf = 1,

    [Description("-INF")]
    MinusInf = 2,
}
