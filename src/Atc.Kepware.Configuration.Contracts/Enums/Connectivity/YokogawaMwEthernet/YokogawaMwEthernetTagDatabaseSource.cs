namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaMwEthernet;

/// <summary>
/// Yokogawa MW Ethernet tag database generation source.
/// </summary>
public enum YokogawaMwEthernetTagDatabaseSource
{
    [Description("Physical Channel Number")]
    PhysicalChannelNumber = 0,

    [Description("Device Tagname")]
    DeviceTagname = 1,
}