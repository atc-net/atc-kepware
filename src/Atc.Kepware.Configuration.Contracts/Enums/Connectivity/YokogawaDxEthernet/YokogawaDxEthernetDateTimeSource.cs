namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaDxEthernet;

/// <summary>
/// Yokogawa DX Ethernet date and time source.
/// </summary>
public enum YokogawaDxEthernetDateTimeSource
{
    [Description("Device Time")]
    DeviceTime = 0,

    [Description("System Time")]
    SystemTime = 1,
}
