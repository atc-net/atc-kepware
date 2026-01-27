namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaGxEthernet;

/// <summary>
/// Yokogawa GX Ethernet date format.
/// </summary>
public enum YokogawaGxEthernetDateFormat
{
    [Description("MM/DD/YY")]
    MmDdYy = 0,

    [Description("YY/MM/DD")]
    YyMmDd = 1,

    [Description("DD/MM/YY")]
    DdMmYy = 2,
}
