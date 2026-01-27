namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaMxEthernet;

/// <summary>
/// Yokogawa MX Ethernet date format.
/// </summary>
public enum YokogawaMxEthernetDateFormat
{
    [Description("MM/DD/YY")]
    MmDdYy = 0,

    [Description("YY/MM/DD")]
    YyMmDd = 1,

    [Description("DD/MM/YY")]
    DdMmYy = 2,
}
