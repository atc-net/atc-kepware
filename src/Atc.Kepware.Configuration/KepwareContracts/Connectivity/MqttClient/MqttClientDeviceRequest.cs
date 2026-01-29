namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MqttClient;

/// <summary>
/// Device request properties for the MQTT Client driver.
/// </summary>
internal sealed class MqttClientDeviceRequest : DeviceRequestBase, IMqttClientDeviceRequest
{
    public MqttClientDeviceRequest()
        : base(DriverType.MqttClient)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("mqtt_client.DEVICE_TAG_GENERATION_TOPIC")]
    public string? TagGenerationTopic { get; set; } = "#";

    /// <inheritdoc />
    [Range(10, 3600)]
    [JsonPropertyName("mqtt_client.DEVICE_TAG_GENERATION_DURATION")]
    public int TagGenerationDuration { get; set; } = 60;

    /// <inheritdoc />
    [JsonPropertyName("mqtt_client.DEVICE_CANCEL_TAG_GENERATION")]
    public bool CancelTagGeneration { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(TagGenerationTopic)}: {TagGenerationTopic}";
}