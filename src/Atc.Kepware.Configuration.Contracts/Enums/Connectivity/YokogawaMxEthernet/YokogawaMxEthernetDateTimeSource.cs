namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaMxEthernet;

/// <summary>
/// Yokogawa MX Ethernet date and time source.
/// </summary>
public enum YokogawaMxEthernetDateTimeSource
{
    [Description("Device Time")]
    DeviceTime = 0,

    [Description("System Time")]
    SystemTime = 1,
}