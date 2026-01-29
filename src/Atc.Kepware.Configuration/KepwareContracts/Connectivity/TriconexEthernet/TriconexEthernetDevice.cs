namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.TriconexEthernet;

/// <summary>
/// Device properties for the Triconex Ethernet driver.
/// </summary>
internal sealed class TriconexEthernetDevice : DeviceBase, ITriconexEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_ID_DECIMAL")]
    public int DeviceId { get; set; } = 1;

    [JsonPropertyName("triconex_ethernet.DEVICE_PRIMARY_NETWORK_CM_IP")]
    public string PrimaryNetworkCmIp { get; set; } = "0.0.0.0";

    [JsonPropertyName("triconex_ethernet.DEVICE_SECONDARY_NETWORK_CM_IP")]
    public string? SecondaryNetworkCmIp { get; set; } = "0.0.0.0";

    [JsonPropertyName("triconex_ethernet.DEVICE_BIN_DATA_UPDATE_PERIOD")]
    public int BinDataUpdatePeriod { get; set; } = 1000;

    [JsonPropertyName("triconex_ethernet.DEVICE_SUBSCRIPTION_INTERVAL")]
    public int SubscriptionInterval { get; set; } = 10;

    [JsonPropertyName("triconex_ethernet.DEVICE_USE_TIMESTAMP_FROM_DEVICE")]
    public bool UseTimestampFromDevice { get; set; }

    [JsonPropertyName("triconex_ethernet.DEVICE_VARIABLE_IMPORT_FILE")]
    public string? VariableImportFile { get; set; }

    [JsonPropertyName("triconex_ethernet.DEVICE_IMPORT_NODE_NAME")]
    public string? ImportNodeName { get; set; } = "TRINODE";

    [JsonPropertyName("triconex_ethernet.DEVICE_GENERATE_DEVICE_SYSTEM_TAGS")]
    public bool GenerateDeviceSystemTags { get; set; }

    [JsonPropertyName("triconex_ethernet.DEVICE_GENERATE_DRIVER_SYSTEM_TAGS")]
    public bool GenerateDriverSystemTags { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PrimaryNetworkCmIp)}: {PrimaryNetworkCmIp}, {nameof(SecondaryNetworkCmIp)}: {SecondaryNetworkCmIp}, {nameof(BinDataUpdatePeriod)}: {BinDataUpdatePeriod}, {nameof(SubscriptionInterval)}: {SubscriptionInterval}";
}