namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaDarwinEthernet;

/// <summary>
/// Yokogawa Darwin Ethernet date format.
/// </summary>
public enum YokogawaDarwinEthernetDateFormat
{
    [Description("MM/DD/YY")]
    MmDdYy = 0,

    [Description("YY/MM/DD")]
    YyMmDd = 1,

    [Description("DD/MM/YY")]
    DdMmYy = 2,
}