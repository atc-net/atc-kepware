namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.CustomInterface;

/// <summary>
/// Channel properties for the Custom Interface driver.
/// </summary>
public interface ICustomInterfaceChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Specify if the configuration name and shared memory size as defined by the configuration file should be overwritten.
    /// In the absence of a configuration file, the associated parameters may be used to manually define the configuration name and shared memory size.
    /// </summary>
    bool OverrideConfigurationFile { get; set; }

    /// <summary>
    /// Specify the configuration file to use to configure this channel.
    /// The configuration file contains information necessary for shared memory access and device configuration.
    /// </summary>
    /// <remarks>
    /// Only enabled when OverrideConfigurationFile is false.
    /// </remarks>
    string? ConfigurationFile { get; set; }

    /// <summary>
    /// Specify if the configuration file should be reloaded.
    /// This will also start automatic device/tag generation.
    /// The file will not be loaded until the changes are applied.
    /// </summary>
    /// <remarks>
    /// Only enabled when OverrideConfigurationFile is false.
    /// </remarks>
    bool RegenerateFile { get; set; }

    /// <summary>
    /// Specify the configuration name that the channel will use when accessing shared memory.
    /// </summary>
    /// <remarks>
    /// Only enabled when OverrideConfigurationFile is true.
    /// </remarks>
    string? ConfigurationName { get; set; }

    /// <summary>
    /// Specify the shared memory size that the channel will use during tag address validation.
    /// </summary>
    /// <remarks>
    /// Only enabled when OverrideConfigurationFile is true.
    /// </remarks>
    long SharedMemorySizeBytes { get; set; }
}
