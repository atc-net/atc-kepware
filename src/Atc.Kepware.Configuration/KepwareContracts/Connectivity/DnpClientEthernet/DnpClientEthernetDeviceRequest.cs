namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.DnpClientEthernet;

/// <summary>
/// Device request properties for the DNP Client Ethernet driver.
/// </summary>
internal sealed class DnpClientEthernetDeviceRequest : DeviceRequestBase, IDnpClientEthernetDeviceRequest
{
    public DnpClientEthernetDeviceRequest()
        : base(DriverType.DnpClientEthernet)
    {
    }

    /// <inheritdoc />
    [Range(0, 65519)]
    [JsonPropertyName("dnp_master_ethernet.DEVICE_DNP_CLIENT_ADDRESS")]
    public int DnpClientAddress { get; set; } = 3;

    /// <inheritdoc />
    [Range(0, 65519)]
    [JsonPropertyName("dnp_master_ethernet.DEVICE_DNP_SERVER_ADDRESS")]
    public int DnpServerAddress { get; set; } = 4;

    /// <inheritdoc />
    [Range(100, 3600000)]
    [JsonPropertyName("dnp_master_ethernet.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeout { get; set; } = 30000;

    /// <inheritdoc />
    [Range(1, 10)]
    [JsonPropertyName("dnp_master_ethernet.DEVICE_MAX_TIMEOUTS")]
    public int MaxTimeouts { get; set; } = 1;

    /// <inheritdoc />
    [Range(0, 86400)]
    [JsonPropertyName("dnp_master_ethernet.DEVICE_KEEP_ALIVE_INTERVAL_SECONDS")]
    public int KeepAliveInterval { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("dnp_master_ethernet.DEVICE_DNP_SERVER_USES_UTC")]
    public bool DnpServerUsesUtc { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("dnp_master_ethernet.DEVICE_DNP_SERVER_RESPECTS_DST")]
    public bool DnpServerRespectsDst { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("dnp_master_ethernet.DEVICE_HONOR_TIME_SYNC_REQUESTS")]
    public bool HonorTimeSyncRequests { get; set; } = true;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DnpClientAddress)}: {DnpClientAddress}, {nameof(DnpServerAddress)}: {DnpServerAddress}";
}