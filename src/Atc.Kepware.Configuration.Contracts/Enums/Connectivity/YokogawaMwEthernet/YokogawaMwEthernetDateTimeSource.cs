namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaMwEthernet;

/// <summary>
/// Yokogawa MW Ethernet date and time source.
/// </summary>
public enum YokogawaMwEthernetDateTimeSource
{
    [Description("Device Time")]
    DeviceTime = 0,

    [Description("System Time")]
    SystemTime = 1,
}