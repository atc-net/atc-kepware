namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.CustomInterface;

/// <summary>
/// Channel properties for the Custom Interface driver.
/// </summary>
public sealed class CustomInterfaceChannelRequest : ChannelRequestBase, ICustomInterfaceChannelRequest
{
    public CustomInterfaceChannelRequest()
        : base(DriverType.CustomInterface)
    {
    }

    /// <inheritdoc />
    public bool OverrideConfigurationFile { get; set; }

    /// <inheritdoc />
    [MaxLength(1024)]
    public string? ConfigurationFile { get; set; }

    /// <inheritdoc />
    public bool RegenerateFile { get; set; }

    /// <inheritdoc />
    [MaxLength(64)]
    public string? ConfigurationName { get; set; }

    /// <inheritdoc />
    [Range(0, 2147483648)]
    public long SharedMemorySizeBytes { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(OverrideConfigurationFile)}: {OverrideConfigurationFile}, {nameof(ConfigurationFile)}: {ConfigurationFile}, {nameof(ConfigurationName)}: {ConfigurationName}, {nameof(SharedMemorySizeBytes)}: {SharedMemorySizeBytes}";
}