namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaGxEthernet;

/// <summary>
/// Yokogawa GX Ethernet data handling for out of range and error conditions.
/// </summary>
public enum YokogawaGxEthernetDataHandling
{
    [Description("None")]
    None = 0,

    [Description("+INF")]
    PlusInf = 1,

    [Description("-INF")]
    MinusInf = 2,
}
