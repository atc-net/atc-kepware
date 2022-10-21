namespace Atc.Kepware.Configuration.KepwareContracts.IotGateway;

internal sealed class IotItem : IIotItem
{
    /// <inheritdoc />
    [JsonPropertyName("PROJECT_ID")]
    public long ProjectId { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("common.ALLTYPES_NAME")]
    public string Name { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("common.ALLTYPES_DESCRIPTION")]
    public string Description { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.IOT_ITEM_SERVER_TAG")]
    public string ServerTag { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.IOT_ITEM_USE_SCAN_RATE")]
    public bool UsesScanRate { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.IOT_ITEM_SCAN_RATE_MS")]
    public int ScanRate { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.IOT_ITEM_SEND_EVERY_SCAN")]
    public bool SendEveryScan { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.IOT_ITEM_DEADBAND_PERCENT")]
    public int DeadBandPercent { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.IOT_ITEM_ENABLED")]
    public bool Enabled { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(ProjectId)}: {ProjectId}, {nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(ServerTag)}: {ServerTag}, {nameof(UsesScanRate)}: {UsesScanRate}, {nameof(ScanRate)}: {ScanRate}, {nameof(SendEveryScan)}: {SendEveryScan}, {nameof(DeadBandPercent)}: {DeadBandPercent}, {nameof(Enabled)}: {Enabled}";
}