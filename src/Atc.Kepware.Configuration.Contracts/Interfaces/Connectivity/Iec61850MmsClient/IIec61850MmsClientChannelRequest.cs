namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.Iec61850MmsClient;

/// <summary>
/// Channel properties for the IEC 61850 MMS Client driver.
/// </summary>
public interface IIec61850MmsClientChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Enable to allocate only the memory needed for the channel.
    /// This can help reduce the memory footprint of the application.
    /// However, if devices are added to a channel while it has been set to optimize,
    /// data loss could occur for a brief period while memory is reallocated.
    /// </summary>
    bool OptimizeMemoryAllocation { get; set; }
}
