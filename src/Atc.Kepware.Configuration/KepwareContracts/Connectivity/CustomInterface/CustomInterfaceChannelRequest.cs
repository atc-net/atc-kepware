namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.CustomInterface;

/// <summary>
/// Channel properties for the Custom Interface driver.
/// </summary>
internal sealed class CustomInterfaceChannelRequest : ChannelRequestBase, ICustomInterfaceChannelRequest
{
    public CustomInterfaceChannelRequest()
        : base(DriverType.CustomInterface)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.CHANNEL_OVERRIDE_CONFIGURATION_FILE")]
    public bool OverrideConfigurationFile { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.CHANNEL_CONFIGURATION_FILE")]
    [MaxLength(1024)]
    public string? ConfigurationFile { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.CHANNEL_REGENERATE")]
    public bool RegenerateFile { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.CHANNEL_CONFIGURATION_NAME")]
    [MaxLength(64)]
    public string? ConfigurationName { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.CHANNEL_SHARED_MEMORY_SIZE_BYTES")]
    [Range(0, 2147483648)]
    public long SharedMemorySizeBytes { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(OverrideConfigurationFile)}: {OverrideConfigurationFile}, {nameof(ConfigurationFile)}: {ConfigurationFile}, {nameof(ConfigurationName)}: {ConfigurationName}, {nameof(SharedMemorySizeBytes)}: {SharedMemorySizeBytes}";
}
