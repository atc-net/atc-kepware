namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaGxEthernet;

/// <summary>
/// Yokogawa GX Ethernet date and time source.
/// </summary>
public enum YokogawaGxEthernetDateTimeSource
{
    [Description("Device Time")]
    DeviceTime = 0,

    [Description("System Time")]
    SystemTime = 1,
}
