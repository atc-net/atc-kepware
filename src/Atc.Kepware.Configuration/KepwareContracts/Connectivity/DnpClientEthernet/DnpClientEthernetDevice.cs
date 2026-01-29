namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.DnpClientEthernet;

/// <summary>
/// Device properties for the DNP Client Ethernet driver.
/// </summary>
internal sealed class DnpClientEthernetDevice : DeviceBase, IDnpClientEthernetDevice
{
    [JsonPropertyName("dnp_master_ethernet.DEVICE_DNP_CLIENT_ADDRESS")]
    public int DnpClientAddress { get; set; }

    [JsonPropertyName("dnp_master_ethernet.DEVICE_DNP_SERVER_ADDRESS")]
    public int DnpServerAddress { get; set; }

    [JsonPropertyName("dnp_master_ethernet.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeout { get; set; }

    [JsonPropertyName("dnp_master_ethernet.DEVICE_MAX_TIMEOUTS")]
    public int MaxTimeouts { get; set; }

    [JsonPropertyName("dnp_master_ethernet.DEVICE_KEEP_ALIVE_INTERVAL_SECONDS")]
    public int KeepAliveInterval { get; set; }

    [JsonPropertyName("dnp_master_ethernet.DEVICE_DNP_SERVER_USES_UTC")]
    public bool DnpServerUsesUtc { get; set; }

    [JsonPropertyName("dnp_master_ethernet.DEVICE_DNP_SERVER_RESPECTS_DST")]
    public bool DnpServerRespectsDst { get; set; }

    [JsonPropertyName("dnp_master_ethernet.DEVICE_HONOR_TIME_SYNC_REQUESTS")]
    public bool HonorTimeSyncRequests { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(DnpClientAddress)}: {DnpClientAddress}, {nameof(DnpServerAddress)}: {DnpServerAddress}";
}