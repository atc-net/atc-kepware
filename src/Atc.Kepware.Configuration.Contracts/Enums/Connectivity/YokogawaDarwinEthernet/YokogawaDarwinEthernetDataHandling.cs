namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaDarwinEthernet;

/// <summary>
/// Yokogawa Darwin Ethernet data handling for out of range and error conditions.
/// </summary>
public enum YokogawaDarwinEthernetDataHandling
{
    [Description("None")]
    None = 0,

    [Description("+INF")]
    PlusInf = 1,

    [Description("-INF")]
    MinusInf = 2,
}