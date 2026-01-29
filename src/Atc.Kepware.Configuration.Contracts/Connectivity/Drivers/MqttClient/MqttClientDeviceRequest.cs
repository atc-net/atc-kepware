namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MqttClient;

/// <summary>
/// Represents an MQTT Client device creation request.
/// </summary>
public class MqttClientDeviceRequest : DeviceRequestBase, IMqttClientDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MqttClientDeviceRequest"/> class.
    /// </summary>
    public MqttClientDeviceRequest()
        : base(DriverType.MqttClient)
    {
    }

    /// <inheritdoc />
    [MaxLength(1024)]
    public string? TagGenerationTopic { get; set; } = "#";

    /// <inheritdoc />
    [Range(10, 3600)]
    public int TagGenerationDuration { get; set; } = 60;

    /// <inheritdoc />
    public bool CancelTagGeneration { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(TagGenerationTopic)}: {TagGenerationTopic}";
}