namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.CustomInterface;

public interface ICustomInterfaceChannel : IChannelBase
{
    /// <summary>
    /// Indicates if the configuration file settings should be overridden.
    /// </summary>
    bool OverrideConfigurationFile { get; set; }

    /// <summary>
    /// The configuration file to use to configure this channel.
    /// </summary>
    string? ConfigurationFile { get; set; }

    /// <summary>
    /// Indicates if the configuration file should be reloaded.
    /// </summary>
    bool RegenerateFile { get; set; }

    /// <summary>
    /// The configuration name that the channel will use when accessing shared memory.
    /// </summary>
    string? ConfigurationName { get; set; }

    /// <summary>
    /// The shared memory size that the channel will use during tag address validation.
    /// </summary>
    long SharedMemorySizeBytes { get; set; }

    /// <summary>
    /// Supporting party's company name.
    /// </summary>
    string? CompanyName { get; set; }

    /// <summary>
    /// Supporting party's phone number.
    /// </summary>
    string? Phone { get; set; }

    /// <summary>
    /// Supporting party's email address.
    /// </summary>
    string? Email { get; set; }

    /// <summary>
    /// Supporting party's web address.
    /// </summary>
    string? Web { get; set; }

    /// <summary>
    /// Supporting party's additional information.
    /// </summary>
    string? ContactAdditional { get; set; }

    /// <summary>
    /// Brief instructions on how to start the supporting party's Configuration component.
    /// </summary>
    string? ToLaunchTheConfiguration { get; set; }

    /// <summary>
    /// Brief instructions on how to start the supporting party's Runtime component.
    /// </summary>
    string? ToLaunchTheRuntime { get; set; }

    /// <summary>
    /// Brief instructions on how to access the supporting party's help documentation.
    /// </summary>
    string? ToLaunchTheHelp { get; set; }

    /// <summary>
    /// Miscellaneous information.
    /// </summary>
    string? Additional { get; set; }
}
