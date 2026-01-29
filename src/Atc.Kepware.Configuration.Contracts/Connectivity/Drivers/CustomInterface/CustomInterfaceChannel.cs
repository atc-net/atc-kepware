namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.CustomInterface;

public sealed class CustomInterfaceChannel : ChannelBase, ICustomInterfaceChannel
{
    /// <inheritdoc />
    public bool OverrideConfigurationFile { get; set; }

    /// <inheritdoc />
    public string? ConfigurationFile { get; set; }

    /// <inheritdoc />
    public bool RegenerateFile { get; set; }

    /// <inheritdoc />
    public string? ConfigurationName { get; set; }

    /// <inheritdoc />
    public long SharedMemorySizeBytes { get; set; }

    /// <inheritdoc />
    public string? CompanyName { get; set; }

    /// <inheritdoc />
    public string? Phone { get; set; }

    /// <inheritdoc />
    public string? Email { get; set; }

    /// <inheritdoc />
    public string? Web { get; set; }

    /// <inheritdoc />
    public string? ContactAdditional { get; set; }

    /// <inheritdoc />
    public string? ToLaunchTheConfiguration { get; set; }

    /// <inheritdoc />
    public string? ToLaunchTheRuntime { get; set; }

    /// <inheritdoc />
    public string? ToLaunchTheHelp { get; set; }

    /// <inheritdoc />
    public string? Additional { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(OverrideConfigurationFile)}: {OverrideConfigurationFile}, {nameof(ConfigurationFile)}: {ConfigurationFile}, {nameof(ConfigurationName)}: {ConfigurationName}, {nameof(SharedMemorySizeBytes)}: {SharedMemorySizeBytes}";
}
