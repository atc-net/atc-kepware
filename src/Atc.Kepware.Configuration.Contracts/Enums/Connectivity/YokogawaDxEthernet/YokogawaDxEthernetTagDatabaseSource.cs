namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaDxEthernet;

/// <summary>
/// Yokogawa DX Ethernet tag database generation source.
/// </summary>
public enum YokogawaDxEthernetTagDatabaseSource
{
    [Description("Physical Channel Number")]
    PhysicalChannelNumber = 0,

    [Description("Device Tagname")]
    DeviceTagname = 1,

    [Description("Device Tagname (Enhanced)")]
    DeviceTagnameEnhanced = 2,
}