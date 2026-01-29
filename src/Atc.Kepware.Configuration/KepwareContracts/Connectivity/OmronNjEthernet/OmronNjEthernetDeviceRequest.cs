namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.OmronNjEthernet;

/// <summary>
/// Omron NJ Ethernet device request - Kepware format.
/// </summary>
internal sealed class OmronNjEthernetDeviceRequest : DeviceRequestBase, IOmronNjEthernetDeviceRequest
{
    public OmronNjEthernetDeviceRequest()
        : base(DriverType.OmronNjEthernet)
    {
    }

    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public OmronNjEthernetModel Model { get; set; } = OmronNjEthernetModel.OmronNj;

    [JsonPropertyName("omron_nj_ethernet.DEVICE_PORT_NUMBER")]
    public int Port { get; set; } = 44818;

    [JsonPropertyName("omron_nj_ethernet.DEVICE_COMMUNICATIONS_CIP_CONNECTION_SIZE_BYTES")]
    public int ConnectionSize { get; set; } = 1996;

    [JsonPropertyName("omron_nj_ethernet.DEVICE_COMMUNICATIONS_INACTIVITY_WATCHDOG")]
    public OmronNjEthernetInactivityWatchdog InactivityWatchdog { get; set; } = OmronNjEthernetInactivityWatchdog.Seconds32;

    [JsonPropertyName("omron_nj_ethernet.DEVICE_COMMUNICATIONS_NJ_ARRAY_BLOCK_SIZE")]
    public OmronNjEthernetArrayBlockSize ArrayBlockSize { get; set; } = OmronNjEthernetArrayBlockSize.Elements120;

    [JsonPropertyName("omron_nj_ethernet.DEVICE_ENABLE_PERFORMANCE_STATISTICS")]
    public bool PerformanceStatistics { get; set; }

    [JsonPropertyName("omron_nj_ethernet.DEVICE_TAG_HIERARCHY")]
    public OmronNjEthernetTagHierarchy TagHierarchy { get; set; } = OmronNjEthernetTagHierarchy.Expanded;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(Port)}: {Port}, {nameof(ConnectionSize)}: {ConnectionSize}, {nameof(InactivityWatchdog)}: {InactivityWatchdog}, {nameof(ArrayBlockSize)}: {ArrayBlockSize}, {nameof(PerformanceStatistics)}: {PerformanceStatistics}, {nameof(TagHierarchy)}: {TagHierarchy}";
}