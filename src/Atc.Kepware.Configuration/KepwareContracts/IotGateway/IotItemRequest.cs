namespace Atc.Kepware.Configuration.KepwareContracts.IotGateway;

internal class IotItemRequest : IIotItemRequest
{
    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.IOT_ITEM_SERVER_TAG")]
    public string ServerTag { get; set; } = string.Empty;

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
}