namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaDxEthernet;

/// <summary>
/// Yokogawa DX Ethernet date format.
/// </summary>
public enum YokogawaDxEthernetDateFormat
{
    [Description("MM/DD/YY")]
    MmDdYy = 0,

    [Description("YY/MM/DD")]
    YyMmDd = 1,

    [Description("DD/MM/YY")]
    DdMmYy = 2,
}
