namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaDarwinEthernet;

/// <summary>
/// Yokogawa Darwin Ethernet date and time source.
/// </summary>
public enum YokogawaDarwinEthernetDateTimeSource
{
    [Description("Device Time")]
    DeviceTime = 0,

    [Description("System Time")]
    SystemTime = 1,
}
