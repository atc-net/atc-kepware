namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.CustomInterface;

/// <summary>
/// Channel properties for the Custom Interface driver.
/// </summary>
internal sealed class CustomInterfaceChannel : ChannelBase, ICustomInterfaceChannel
{
    /// <inheritdoc />
    [JsonPropertyName("custom_interface.CHANNEL_OVERRIDE_CONFIGURATION_FILE")]
    public bool OverrideConfigurationFile { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.CHANNEL_CONFIGURATION_FILE")]
    public string? ConfigurationFile { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.CHANNEL_REGENERATE")]
    public bool RegenerateFile { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.CHANNEL_CONFIGURATION_NAME")]
    public string? ConfigurationName { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.CHANNEL_SHARED_MEMORY_SIZE_BYTES")]
    public long SharedMemorySizeBytes { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.CHANNEL_COMPANY_NAME")]
    public string? CompanyName { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.CHANNEL_PHONE")]
    public string? Phone { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.CHANNEL_EMAIL")]
    public string? Email { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.CHANNEL_WEB")]
    public string? Web { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.CHANNEL_TS_CONTACT_INFORMATION_ADDITIONAL")]
    public string? ContactAdditional { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.CHANNEL_TO_LAUNCH_THE_CONFIGURATION")]
    public string? ToLaunchTheConfiguration { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.CHANNEL_TO_LAUNCH_THE_RUNTIME")]
    public string? ToLaunchTheRuntime { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.CHANNEL_TO_LAUNCH_THE_HELP")]
    public string? ToLaunchTheHelp { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.CHANNEL_ADDITIONAL")]
    public string? Additional { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(OverrideConfigurationFile)}: {OverrideConfigurationFile}, {nameof(ConfigurationFile)}: {ConfigurationFile}, {nameof(ConfigurationName)}: {ConfigurationName}, {nameof(SharedMemorySizeBytes)}: {SharedMemorySizeBytes}";
}