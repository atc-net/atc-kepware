namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.OmronNjEthernet;

/// <summary>
/// Omron NJ Ethernet array block size (maximum number of array elements read in a single transaction).
/// </summary>
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "Values match Kepware API.")]
public enum OmronNjEthernetArrayBlockSize
{
    [Description("30")]
    Elements30 = 30,

    [Description("60")]
    Elements60 = 60,

    [Description("120")]
    Elements120 = 120,

    [Description("240")]
    Elements240 = 240,

    [Description("480")]
    Elements480 = 480,

    [Description("960")]
    Elements960 = 960,

    [Description("1920")]
    Elements1920 = 1920,

    [Description("3840")]
    Elements3840 = 3840,
}