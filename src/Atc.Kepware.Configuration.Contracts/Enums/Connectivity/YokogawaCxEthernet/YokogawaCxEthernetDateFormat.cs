namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaCxEthernet;

/// <summary>
/// Yokogawa CX Ethernet date format.
/// </summary>
public enum YokogawaCxEthernetDateFormat
{
    [Description("MM/DD/YY")]
    MmDdYy = 0,

    [Description("YY/MM/DD")]
    YyMmDd = 1,

    [Description("DD/MM/YY")]
    DdMmYy = 2,
}