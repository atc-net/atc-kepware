namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MqttClient;

/// <summary>
/// Represents an MQTT Client device.
/// </summary>
public class MqttClientDevice : DeviceBase, IMqttClientDevice
{
    /// <inheritdoc />
    public string? TagGenerationTopic { get; set; }

    /// <inheritdoc />
    public int TagGenerationDuration { get; set; }

    /// <inheritdoc />
    public bool CancelTagGeneration { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(TagGenerationTopic)}: {TagGenerationTopic}";
}