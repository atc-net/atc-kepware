namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaCxEthernet;

/// <summary>
/// Yokogawa CX Ethernet date and time source.
/// </summary>
public enum YokogawaCxEthernetDateTimeSource
{
    [Description("Device Time")]
    DeviceTime = 0,

    [Description("System Time")]
    SystemTime = 1,
}
