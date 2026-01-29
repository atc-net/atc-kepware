namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaDxpEthernet;

/// <summary>
/// Yokogawa DXP Ethernet date and time source.
/// </summary>
public enum YokogawaDxpEthernetDateTimeSource
{
    [Description("Device Time")]
    DeviceTime = 0,

    [Description("System Time")]
    SystemTime = 1,
}