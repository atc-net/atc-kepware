namespace Atc.Kepware.Configuration.KepwareContracts.IotGateway;

internal sealed class IotItemUpdateRequest : IIotItemUpdateRequest
{
    /// <inheritdoc />
    [JsonPropertyName("PROJECT_ID")]
    public long ProjectId { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.IOT_ITEM_SCAN_RATE_MS")]
    public int? ScanRate { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.IOT_ITEM_SEND_EVERY_SCAN")]
    public bool? SendEveryScan { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.IOT_ITEM_DEADBAND_PERCENT")]
    public int? DeadBandPercent { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.IOT_ITEM_ENABLED")]
    public bool? Enabled { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(ScanRate)}: {ScanRate}, {nameof(SendEveryScan)}: {SendEveryScan}, {nameof(DeadBandPercent)}: {DeadBandPercent}, {nameof(Enabled)}: {Enabled}";
}