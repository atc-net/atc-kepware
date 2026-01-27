namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaMwEthernet;

/// <summary>
/// Yokogawa MW Ethernet date format.
/// </summary>
public enum YokogawaMwEthernetDateFormat
{
    [Description("MM/DD/YY")]
    MmDdYy = 0,

    [Description("YY/MM/DD")]
    YyMmDd = 1,

    [Description("DD/MM/YY")]
    DdMmYy = 2,
}
