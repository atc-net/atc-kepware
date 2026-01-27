namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaDxpEthernet;

/// <summary>
/// Yokogawa DXP Ethernet date format.
/// </summary>
public enum YokogawaDxpEthernetDateFormat
{
    [Description("MM/DD/YY")]
    MmDdYy = 0,

    [Description("YY/MM/DD")]
    YyMmDd = 1,

    [Description("DD/MM/YY")]
    DdMmYy = 2,
}
