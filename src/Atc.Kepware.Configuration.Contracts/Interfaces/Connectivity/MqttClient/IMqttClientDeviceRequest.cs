namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.MqttClient;

/// <summary>
/// Defines the MQTT Client device request properties.
/// </summary>
public interface IMqttClientDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the topic for automatic tag generation.
    /// </summary>
    /// <remarks>
    /// Must be a valid MQTT topic and can include wildcards. Default: "#".
    /// </remarks>
    string? TagGenerationTopic { get; set; }

    /// <summary>
    /// Gets or sets the duration for automatic tag generation in seconds.
    /// </summary>
    /// <remarks>
    /// Valid range: 10-3600. Default: 60.
    /// </remarks>
    int TagGenerationDuration { get; set; }

    /// <summary>
    /// Gets or sets whether to cancel automatic tag generation in progress.
    /// </summary>
    /// <remarks>
    /// This is a write-only property that cancels ATG when set to true.
    /// </remarks>
    bool CancelTagGeneration { get; set; }
}