namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MqttClient;

/// <summary>
/// Device properties for the MQTT Client driver.
/// </summary>
internal sealed class MqttClientDevice : DeviceBase, IMqttClientDevice
{
    [JsonPropertyName("mqtt_client.DEVICE_TAG_GENERATION_TOPIC")]
    public string? TagGenerationTopic { get; set; }

    [JsonPropertyName("mqtt_client.DEVICE_TAG_GENERATION_DURATION")]
    public int TagGenerationDuration { get; set; }

    [JsonPropertyName("mqtt_client.DEVICE_CANCEL_TAG_GENERATION")]
    public bool CancelTagGeneration { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(TagGenerationTopic)}: {TagGenerationTopic}";
}
