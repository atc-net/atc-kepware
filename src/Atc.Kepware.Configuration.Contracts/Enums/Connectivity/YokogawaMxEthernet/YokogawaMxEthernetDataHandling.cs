namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaMxEthernet;

/// <summary>
/// Yokogawa MX Ethernet data handling for special condition statuses.
/// </summary>
public enum YokogawaMxEthernetDataHandling
{
    [Description("-INF/+INF")]
    MinusInfPlusInf = 0,

    [Description("-99999/+99999")]
    Minus99999Plus99999 = 1,
}
